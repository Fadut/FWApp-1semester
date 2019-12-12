using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    public class Equipment
    {
        private int _iD;
        private string _name;
        private string _muscleGroup;
        private string _description;

        public Equipment() { }
        public Equipment(int iD, string name, string muscleGroup, string description)
        {
            _iD = iD;
            _name = name;
            _muscleGroup = muscleGroup;
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

        public string MuscleGroup
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
            return $"{nameof(ID)}: {ID}, {nameof(Name)}: {Name}, {nameof(MuscleGroup)}: {MuscleGroup}, {nameof(Description)}: {Description}";
        }
    }
}
