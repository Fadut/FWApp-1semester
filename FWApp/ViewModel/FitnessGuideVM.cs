using FWApp.Common;
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
        private ObservableCollection<Equipment> _equipments;
        private Equipment _selectedEquipment;
        private int _selectedID;
        private RelayCommand _søgningCommand;
        private Catalog catalog = new Catalog();
        public SharedKnowledgeSingleton _shared;

        public ObservableCollection<Equipment> Equipments
        {
            get { return _equipments; }
            set
            {
                _equipments = value;
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

        public int SelectedID
        {
            get { return _selectedID; }
            set
            {
                _selectedID = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand SøgningCommand
        {
            get { return _søgningCommand; }
            set { _søgningCommand = value; }
        }

        public SharedKnowledgeSingleton Shared
        {
            get { return _shared; }
        }

        public FitnessGuideVM()
        {
            catalog = new Catalog();
            _equipments = new ObservableCollection<Equipment>(catalog.Equipment);

            _selectedEquipment = new Equipment(0, "Navn", "Muskelgruppe", "Forklaring");
            
            SøgningCommand = new RelayCommand(SøgEquipment);
            _shared = SharedKnowledgeSingleton.Instance;
        }



        public void SøgEquipment()
        {
           foreach(var m in catalog._maskiner)
            {
                if (m.ID == SelectedID)
                {
                    _shared.Found = m;
                }
            }
            
            
        }


    }
}
