using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SmirnovIA.Sprint7.Project.V14.Lib;

namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    public partial class FormRoute_SIA : Form
    {
        public FormRoute_SIA()
        {
            InitializeComponent();
        }
        public string[,] valueArray;
        public int routeId;
        DataService ds = new DataService();
        private void FormRoute_Load(object sender, EventArgs e)
        {
            textBoxVehicleAmount_SIA.Text = Convert.ToString(ds.RouteAmount_Route(valueArray, routeId));
            textBoxMinTime_SIA.Text = Convert.ToString(ds.MinTime_Route(valueArray, routeId));
            textBoxMaxTime_SIA.Text = Convert.ToString(ds.MaxTime_Route(valueArray, routeId));
            textBoxAvgTime_SIA.Text = Convert.ToString(ds.AvgTime_Route(valueArray, routeId));
            for (int i = 0; i < valueArray.GetLength(0); i++)
            {
                try 
                {
                    if (Convert.ToInt32(valueArray[i, 2]) == routeId)
                        {
                            try
                            {
                            chartStats_SIA.Series[0].Points.AddXY(valueArray[i, 0], Convert.ToInt32(valueArray[i, 6]));
                            }
                            catch { chartStats_SIA.Series[0].Points.AddXY(valueArray[i, 0], 0); }
                        }
                }
                catch {  }
            }
            
        }
    }
}
