using FWApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWApp.ViewModel
{
    public class FitnessGuideVM : BaseVM
    {
        private ObservableCollection<Equipment> equipments;
        private Equipment _chosenEquipment;

        public ObservableCollection<Equipment> Equipments
        {
            get { return equipments; }
            set
            {
                equipments = value;
                OnPropertyChanged();
            }
        }

        public Equipment ChosenEquipment
        {
            get { return _chosenEquipment; }
            set
            {
                _chosenEquipment = value;
                OnPropertyChanged();
            }
        }

        public FitnessGuideVM()
        {
            equipments = new ObservableCollection<Equipment>();

            _chosenEquipment = new Equipment(0, "Navn", "MuskelGruppe", "Forklaring");
        }


    }
}
