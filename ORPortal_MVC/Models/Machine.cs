using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ORPortal_MVC.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TOS { get; set; }
        public int Pulses { get; set; }
        public int Pieces { get; set; }
        public double Rmin { get; set; }
        public double Rmax { get; set; }
        public double Omin { get; set; }
        public double Omax { get; set; }
        public double Gmin { get; set; }
        public double Gmax { get; set; }
        public Nullable<int> MachineGroupId { get; set; }
        public Nullable<double> MPDuration { get; set; }
        public Nullable<double> StopCloseDuration { get; set; }
    }
}