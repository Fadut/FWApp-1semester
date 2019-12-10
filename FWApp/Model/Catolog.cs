using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    class Catolog
    {
        private List<Equipment> _maskiner;

        public Catolog()
        {
            _maskiner = new List<Equipment>();

            _maskiner.Add(new Equipment(1, "Push Ups", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(2, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(3, "Bench Press", "Arm", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(4, "Hammer", "Ryg", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(5, "Push Ups", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(6, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(7, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(8, "Hammer", "Ryg", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(9, "Push Ups", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(10, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(11, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(12, "Hammer", "Ryg", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(13, "Push Ups", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(14, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(15, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(16, "Hammer", "Ryg", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(17, "Push Ups", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(18, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(19, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(20, "Hammer", "Ryg", "Husk at på denne, skal du..."));
            _maskiner.Add(new Equipment(21, "Push Ups", "Arm", "Du skal..."));
            _maskiner.Add(new Equipment(22, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(23, "Leg Push", "Ben", "Her er det vigtigt, at..."));
            _maskiner.Add(new Equipment(24, "Hammer", "Ryg", "Husk at på denne, skal du..."));
        }

    }
}
