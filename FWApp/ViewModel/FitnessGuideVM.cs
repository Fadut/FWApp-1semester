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
        private Equipment _selectedEquipment;

        public ObservableCollection<Equipment> Equipments
        {
            get { return equipments; }
            set
            {
                equipments = value;
                OnPropertyChanged();
            }
        }

        public Equipment SelectedEquipment
        {
            get { return _selectedEquipment; }
            set
            {
                _selectedEquipment = value;
                OnPropertyChanged();
            }
        }

        public FitnessGuideVM()
        {
            equipments = new ObservableCollection<Equipment>();

            _selectedEquipment = new Equipment(0, "Navn", "Muskel Gruppe", "Forklaring");
        }


    }
}
