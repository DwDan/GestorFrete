using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acess;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET;
using Interface;
using GMap.NET.WindowsForms.Markers;

namespace UI
{
    public partial class FormPrincipal : Form
    {
        public GMapOverlay GMapOverlay = new GMapOverlay();

        public FormPrincipal()
        {
            InitializeComponent();
            DatabaseContext DatabaseContext = new DatabaseContext();
            if (DatabaseContext.Municipios.Count() == 0)
                DatabaseContext.DefaultData();

            GoogleMapProvider.Instance.ApiKey = "AIzaSyDSDWEGxqXsPOcVbeR8sSts1FJL0j7Fk8w";
            GMapControl.MinZoom = 3;
            GMapControl.MaxZoom = 19;
            GMapControl.Zoom = 17;
            GMapControl.Manager.Mode = AccessMode.ServerAndCache;
            GMapControl.MapProvider = GMapProviders.GoogleMap;
            GMapControl.Position = new PointLatLng() { Lat = -19.982513, Lng = -43.9456905 };
            GMapControl.DragButton = MouseButtons.Left;
            GMapControl.ShowCenter = false;
            GMapControl.Overlays.Add(GMapOverlay);
            GMapControl.Refresh();

            GerarRota();
        }

        public void GerarRota()
        {
            DatabaseContext DbGMap = new DatabaseContext();
            GMapOverlay.Markers.Clear();
            GMapOverlay.Routes.Clear();

            List<IPassageiro> ListaPassageiro = DbGMap.Passageiros.ToList();

            if (DbGMap.Fretamentos.Count() > 0)
            {
                foreach (IFretamento IFretamento in DbGMap.Fretamentos)
                {
                    List<PointLatLng> WAYPOINTS = new List<PointLatLng>();

                    Random RANDOM = new Random();
                    Color RAMDOMCOLOR = Color.FromArgb(RANDOM.Next(256), RANDOM.Next(256), RANDOM.Next(256));

                    GMarkerGoogle ORIGEM = new GMarkerGoogle(IFretamento.I5_ORG_COORDENADAS, GMarkerGoogleType.MARKER_BEGIN, RAMDOMCOLOR, string.Empty);
                    GMapOverlay.Markers.Add(ORIGEM);
                    WAYPOINTS.Add(ORIGEM.Position);

                    if (!string.IsNullOrEmpty(IFretamento.I5_PASSAGEIROS))
                    {
                        foreach (IPassageiro IPassageiro in ListaPassageiro.Where(x => IFretamento.I5_PASSAGEIROS.Contains(x.I0_ID.ToString().PadLeft(6, '0'))))
                        {
                            GMarkerGoogle WAYPOINT = new GMarkerGoogle(IPassageiro.I0_COORDENADAS, GMarkerGoogleType.MARKER_WAYPOINT, RAMDOMCOLOR, string.Empty);
                            GMapOverlay.Markers.Add(WAYPOINT);
                            WAYPOINTS.Add(WAYPOINT.Position);
                        }
                    }

                    GMarkerGoogle DESTINO = new GMarkerGoogle(IFretamento.I5_DEST_COORDENADAS, GMarkerGoogleType.MARKER_END, RAMDOMCOLOR, string.Empty);
                    GMapOverlay.Markers.Add(DESTINO);
                    WAYPOINTS.Add(DESTINO.Position);

                    GDirections GDirections = new GDirections();
                    DirectionsStatusCode DirectionsStatusCode = DirectionsStatusCode.UNKNOWN_ERROR;
                    DirectionsStatusCode = GoogleMapProvider.Instance.GetDirections(out GDirections, WAYPOINTS.First(), WAYPOINTS.Where(x => x != WAYPOINTS.First() && x != WAYPOINTS.Last()).ToList(), WAYPOINTS.Last(), false, true, false, false, true);
                    if (DirectionsStatusCode != DirectionsStatusCode.OK) { }

                    if (DirectionsStatusCode == DirectionsStatusCode.OK)
                    {
                        GMapRoute GMapRoute = new GMapRoute(GDirections.Route, "Rota Planejada");
                        GMapRoute.Stroke = (Pen)GMapRoute.Stroke.Clone();
                        GMapRoute.Stroke.Color = RAMDOMCOLOR;
                        GMapRoute.Stroke.Width = 5;
                        GMapOverlay.Routes.Add(GMapRoute);
                        GMapControl.Refresh();
                    }
                }
            }

            GMapControl.Refresh();
        }

        public void AddTabPage(UserControl UserControl, string Name)
        {
            List<TabPage> ListaTabPage = TabControl.TabPages.Cast<TabPage>().Where(x => x.Name == Name).ToList();
            if (ListaTabPage.Count > 0)
            {
                TabControl.SelectedTab = ListaTabPage.First();
            }
            else
            {
                TabPage TabPage = new TabPage();
                TabPage.Location = new Point(4, 22);
                TabPage.Name = Name;
                TabPage.Padding = new Padding(3);
                TabPage.Text = Name;
                TabPage.UseVisualStyleBackColor = true;
                UserControl.Dock = DockStyle.Fill;
                TabPage.Controls.Add(UserControl);
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTab = TabPage;
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passageiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlPassageiro ControlPassageiro = new ControlPassageiro(TabControl, new DatabaseContext());
            AddTabPage(ControlPassageiro, "Cadastro de Passageiros");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCliente ControlCliente = new ControlCliente(TabControl, new DatabaseContext());
            AddTabPage(ControlCliente, "Cadastro de Clientes");
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlVeiculo ControlVeiculo = new ControlVeiculo(TabControl, new DatabaseContext());
            AddTabPage(ControlVeiculo, "Cadastro de Veículos");
        }

        private void condutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCondutor ControlCondutor = new ControlCondutor(TabControl, new DatabaseContext());
            AddTabPage(ControlCondutor, "Cadastro de Codutores");
        }

        private void fretamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlFretamento ControlFretamento = new ControlFretamento(TabControl, new DatabaseContext());
            AddTabPage(ControlFretamento, "Fretamento");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tbInicio == TabControl.SelectedTab)
                GerarRota();
        }
    }
}
