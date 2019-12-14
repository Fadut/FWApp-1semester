using FWApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.Model
{
    class Catalog : BaseVM
    {
        public List<Equipment> _maskiner;

        public Catalog()
        {
            _maskiner = new List<Equipment>();

            _maskiner.Add(new Equipment(1, "Chest Press", "Bryst", "Skub håndtagende fremad indtil armene er helt rettede ud.", "https://www.youtube.com/watch?v=xUm0BiZCWlQ"));
            _maskiner.Add(new Equipment(2, "Leg Press", "Ben", "Skub i fodpladen indtil benene er lidt udad.", "https://www.youtube.com/watch?v=IZxyjW7MPJQ"));
            _maskiner.Add(new Equipment(3, "Fly/Rear Delt", "Arm", "Pres håndtagende fremad og mod midten eller pres håndtagende til siden og bagud.", "https://www.youtube.com/watch?v=6yMdhi2DVao"));
            _maskiner.Add(new Equipment(4, "Abdominal", "Mave", "Pres håndtagende fremad ved at bøje dig forover med armene helt strakt ud.", "https://www.youtube.com/watch?v=_O1xunCfYEM"));
            _maskiner.Add(new Equipment(5, "Back Extension", "Ryg", "Pres øverste del af ryggen mod rygstøtten, samtidigt med du ruller lænden over lændestøtten.", "https://www.youtube.com/watch?v=vx0jZBEmZcE"));
            _maskiner.Add(new Equipment(6, "Leg Extension", "Ben", "Skub fremad og op imod puden, indtil benen er lige", "https://www.youtube.com/watch?v=YyvSfVjQeL0"));
            _maskiner.Add(new Equipment(7, "Seated Leg Curl", "Ben", "Skub ned og tilbage imod puden, indtil fødderne er under sædet.", "https://www.youtube.com/watch?v=ELOCsoDSmrg"));
            _maskiner.Add(new Equipment(8, "Hip Abduction Hip Adduction", "Ben", "Tryk imod puderne i en hel bevægelse.", "https://www.youtube.com/watch?v=GmRSV_n2E_0"));
            _maskiner.Add(new Equipment(9, "Pulldown", "Ryg", "Træk håndtagene ned, indtil albuerne er side om side, og håndtagene er på niveau med skulderne.", "https://www.youtube.com/watch?v=CAwf7n6Luuc"));
            _maskiner.Add(new Equipment(10, "Glute", "Ben", "Pres bagud og opad med bevarelse af kropsstilingen. Gentag handlingen.", "https://www.youtube.com/watch?v=5lOLPHbK_NY"));
            _maskiner.Add(new Equipment(11, "Row", "Ryg", "Træk i håndtagene indtil albuerne er på siderne.", "https://www.youtube.com/watch?v=8MKGArS7w7c"));
            _maskiner.Add(new Equipment(12, "Bravo Pull", "Ryg", "Du kan vælge mellem høj række, mellem række, lav række og bagved skulder.", "https://www.youtube.com/watch?v=4yNJaz7XzFg"));
            _maskiner.Add(new Equipment(13, "Lat Pulldown", "Ryg", "Det samme som i Pulldown", "https://www.youtube.com/watch?v=0oeIB6wi3es"));
            _maskiner.Add(new Equipment(14, "Iso-Lateral Super Incline Press", "Bryst", "Skub håndtagene op indtil armene er lige.", "https://www.youtube.com/watch?v=C2B4Ad93_i0"));
            _maskiner.Add(new Equipment(15, "Iso-Lateral High Row", "Ryg", "Løft håndtagene op indtil armene er lige.", "https://www.youtube.com/watch?v=vOBNQkqEAdY"));
            _maskiner.Add(new Equipment(16, "Angled Leg Press", "Ben", "Pres bene op mod pladen så langt du kan.", "https://www.youtube.com/watch?v=VFk3RzndUEc"));
            _maskiner.Add(new Equipment(17, "Adjustable Cable Crossover", "Arm", "Her kan du ændre måden du bruger den på, afhængigt hvad du træner.", "https://www.youtube.com/watch?v=taI4XduLpTk"));
            _maskiner.Add(new Equipment(18, "Dual Pulley Row", "Ryg", "Træk i håndtagene hen til dig, som du kan enten gøre samtidig med begge hænder eller en af gangen.", "https://www.youtube.com/watch?v=tKSCgKI7ZXQ"));
            _maskiner.Add(new Equipment(19, "Adjustable Pulley", "Arm", "Her kan du bestemme om du vil trække ned, op eller lige. Du kan også træne med føderne med den.", "https://www.youtube.com/watch?v=_g9iYq67Nto"));
        }

        public List<Equipment> Equipment
        {
            get { return _maskiner; }
            set 
            { 
                _maskiner = value;
                OnPropertyChanged();
            
            }
        }

    }
}
