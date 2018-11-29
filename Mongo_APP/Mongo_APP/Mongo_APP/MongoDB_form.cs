using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;

namespace Mongo_APP
{


    public partial class MongoDB_form : Form
    {
        public MongoDB_form()
        {
            InitializeComponent();
            FLEX_CONTAINS ctns = new FLEX_CONTAINS();
            FLEX flex = new FLEX
            {
                Serial_Number = "1",
                Orientation = "L",
                Flex_Version = "76",
                Roic_Version = "704b"
            };
            
        }




    }



    public class FLEX
    {
        public ObjectId ID { get; set; }
        public string Serial_Number { get; set; }
        public string Orientation { get; set; }
        public string Flex_Version { get; set; }
        public string Roic_Version { get; set; }
        public string ROIC_Mask { get; set; }
        public string APD_Mask { get; set; }
        public string VDDD { get; set; }
        public string VDDA { get; set; }
        public string VDDP { get; set; }
        public string VDDH { get; set; }
        public string VDDDi { get; set; }
        public string VDDAi { get; set; }
        public string VDDPi { get; set; }
        public string VDDHi { get; set; }
        public string i_Vdet { get; set; }
        public string Failure { get; set; }
        public string Notes { get; set; }
    }


    public class XCVR
    {
        public ObjectId ID { get; set; }
        public string Serial_Number { get; set; }
        public string Orientation { get; set; }
        public string Flex_Version { get; set; }
        public string Roic_Version { get; set; }
        public string ROIC_Mask { get; set; }
        public string APD_Mask { get; set; }
        public string Sensor_Head_Serial_Number { get; set; }
        public string VDDD { get; set; }
        public string VDDA { get; set; }
        public string VDDP { get; set; }
        public string VDDH { get; set; }
        public string VDDDi { get; set; }
        public string VDDAi { get; set; }
        public string VDDPi { get; set; }
        public string VDDHi { get; set; }
        public string i_Vdet { get; set; }
        public string Failure { get; set; }
        public string Notes { get; set; }
    }
}
