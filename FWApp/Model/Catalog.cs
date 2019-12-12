using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    class Catalog
    {
        public List<Equipment> _maskiner;

        public Catalog()
        {
            _maskiner = new List<Equipment>();

            _maskiner.Add(new Equipment(1, "Chest Press", "Bryst", "Du skal..."));
            _maskiner.Add(new Equipment(2, "Leg Press", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(3, "Fly/Rear Delt", "Arm", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(4, "Abdominal", "Mave", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(5, "Back Extension", "Ryg", "Du skal..."));
            _maskiner.Add(new Equipment(6, "Leg Extension", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(7, "Seated Leg Curl", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(8, "Hip Abduction Hip Adduction", "Ben", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(9, "Pulldown", "Ryg", "Du skal..."));
            _maskiner.Add(new Equipment(10, "Glute", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(11, "Row", "Ryg", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(12, "Bravo Pull", "Ryg", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(13, "Lat Pulldown", "Ryg", "Du skal..."));
            _maskiner.Add(new Equipment(14, "Iso-Lateral Super Incline Press", "Bryst", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(15, "Iso-Lateral High Row", "Ryg", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(16, "Linear Leg Press", "Ben", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(17, "Adjustable Cable Crossover", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(18, "Dual Pulley Pulldown", "Ryg", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(19, "Dual Pulley Row", "Ryg", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(20, "Adjustable Pulley", "Arm", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(21, "Push Ups", "Arm", "Du skal..."));
        }

        public List<Equipment> Equipment
        {
            get { return _maskiner; }
            set { _maskiner = value; }
        }

    }
}
