using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Assets.Model
{
    class EquipmentClass
    {
        private int _iD;
        private string _name;
        private string _muscleGroup;
        private string _description;

        public EquipmentClass(int iD, string name, string musclegroup, string description)
        {
            _iD = iD;
            _name = name;
            _muscleGroup = musclegroup;
            _description = description;
        }

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Musclegroup
        {
            get { return _muscleGroup; }
            set { _muscleGroup = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(Name)}: {Name}, {nameof(Musclegroup)}: {Musclegroup}, {nameof(Description)}: {Description}";
        }
    }
}
