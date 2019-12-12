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

            _maskiner.Add(new Equipment(1, "Chest Press", "Bryst", "Du skal...", "https://www.youtube.com/watch?v=xUm0BiZCWlQ"));
            _maskiner.Add(new Equipment(2, "Leg Press", "Ben", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=IZxyjW7MPJQ"));
            _maskiner.Add(new Equipment(3, "Fly/Rear Delt", "Arm", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=6yMdhi2DVao"));
            _maskiner.Add(new Equipment(4, "Abdominal", "Mave", "Husk at på denne, skal du...", "https://www.youtube.com/watch?v=_O1xunCfYEM"));
            _maskiner.Add(new Equipment(5, "Back Extension", "Ryg", "Du skal...", "https://www.youtube.com/watch?v=vx0jZBEmZcE"));
            _maskiner.Add(new Equipment(6, "Leg Extension", "Ben", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=YyvSfVjQeL0"));
            _maskiner.Add(new Equipment(7, "Seated Leg Curl", "Ben", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=ELOCsoDSmrg"));
            _maskiner.Add(new Equipment(8, "Hip Abduction Hip Adduction", "Ben", "Husk at på denne, skal du...", "https://www.youtube.com/watch?v=GmRSV_n2E_0"));
            _maskiner.Add(new Equipment(9, "Pulldown", "Ryg", "Du skal...", "https://www.youtube.com/watch?v=CAwf7n6Luuc"));
            _maskiner.Add(new Equipment(10, "Glute", "Ben", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=5lOLPHbK_NY"));
            _maskiner.Add(new Equipment(11, "Row", "Ryg", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=8MKGArS7w7c"));
            _maskiner.Add(new Equipment(12, "Bravo Pull", "Ryg", "Husk at på denne, skal du...", "https://www.youtube.com/watch?v=4yNJaz7XzFg"));
            _maskiner.Add(new Equipment(13, "Lat Pulldown", "Ryg", "Du skal...", "https://www.youtube.com/watch?v=0oeIB6wi3es"));
            _maskiner.Add(new Equipment(14, "Iso-Lateral Super Incline Press", "Bryst", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=C2B4Ad93_i0"));
            _maskiner.Add(new Equipment(15, "Iso-Lateral High Row", "Ryg", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=vOBNQkqEAdY"));
            _maskiner.Add(new Equipment(16, "Angled Leg Press", "Ben", "Husk at på denne, skal du...", "https://www.youtube.com/watch?v=VFk3RzndUEc"));
            _maskiner.Add(new Equipment(17, "Adjustable Cable Crossover", "Arm", "Du skal...", "https://www.youtube.com/watch?v=taI4XduLpTk"));
            _maskiner.Add(new Equipment(18, "Dual Pulley Row", "Ryg", "Her er det vigtigt, at...", "https://www.youtube.com/watch?v=tKSCgKI7ZXQ"));
            _maskiner.Add(new Equipment(19, "Adjustable Pulley", "Arm", "Husk at på denne, skal du...", "https://www.youtube.com/watch?v=_g9iYq67Nto"));
        }

        public List<Equipment> Equipment
        {
            get { return _maskiner; }
            set { _maskiner = value; }
        }

    }
}
