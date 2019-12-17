﻿using FWApp.Common;
using FWApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace FWApp.ViewModel
{
    public class FitnessGuideVM : BaseVM
    {
        private ObservableCollection<Equipment> _equipments;
        private Equipment _selectedEquipment;
        private int _selectedID;
        private string _selectedMuscleGroup;
        private string _selectedName;
        private RelayCommand _søgningCommandID;
        private RelayCommand _søgningCommandMG;
        private RelayCommand _søgningCommandN;
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

        public string SelectedMuscleGroup
        {
            get { return _selectedMuscleGroup; }
            set
            {
                _selectedMuscleGroup = value;
                Equipments.Clear();
                foreach (var m in FindEquipmentMG())
                {
                    Equipments.Add(m);
                }
                OnPropertyChanged();
            }
        }

        public List<string> MuscleSelection
        {
            get
            {
                List<string> MList = new List<string>();
                foreach (var m in _equipments)
                {
                    if (!MList.Contains(m.MuscleGroup))
                    MList.Add(m.MuscleGroup);
                }
                return MList;
            }
        }

        public string SelectedName
        {
            get { return _selectedName; }
            set
            {
                _selectedName = value;
                Equipments.Clear();
                foreach (var m in FindEquipmentN())
                {
                    Equipments.Add(m);
                }
                OnPropertyChanged();
            }
        }

        public List<string> NameSelection
        {
            get
            {
                List<string> NList = new List<string>();
                return NList;
            }
        }

        public RelayCommand SøgningCommandID
        {
            get { return _søgningCommandID; }
            set { _søgningCommandID = value; }
        }

        public RelayCommand SøgningCommandMG
        {
            get { return _søgningCommandMG; }
            set { _søgningCommandMG = value; }
        }

        public RelayCommand SøgningCommandN
        {
            get { return _søgningCommandN; }
            set { _søgningCommandN = value; }
        }

        public SharedKnowledgeSingleton Shared
        {
            get { return _shared; }
        }

        public FitnessGuideVM()
        {
            catalog = new Catalog();
            _equipments = new ObservableCollection<Equipment>(catalog.Equipment);

            _selectedEquipment = new Equipment(0, "Navn", "Muskelgruppe", "Forklaring", "Videoen");
            
            SøgningCommandID = new RelayCommand(SøgEquipmentID);
            SøgningCommandMG = new RelayCommand(SøgEquipmentMG);
            SøgningCommandN = new RelayCommand(SøgEquipmentN);
            _shared = SharedKnowledgeSingleton.Instance;
        }



        public void SøgEquipmentID()
        {
           foreach(var m in catalog._maskiner)
            {
                if (m.ID == SelectedID)
                {
                    _shared.Found = m;

                    Frame f = (Frame)Window.Current.Content;
                    f.Navigate(typeof(EquipmentGuidePage));
                }
            } 
        }

        public void SøgEquipmentMG()
        {
            foreach (var m in catalog._maskiner)
            {
                if (m.MuscleGroup == SelectedMuscleGroup)
                {
                    _shared.Found = m;
                }
            }
        }

        public List<Equipment> FindEquipmentMG()
        {
            List<Equipment> MGList = new List<Equipment>();
            foreach (var m in catalog._maskiner)
            {
                if (m.MuscleGroup == SelectedMuscleGroup)
                {
                    MGList.Add(m);
                }
            }
            return MGList;
        }

        public void SøgEquipmentN()
        {
            foreach (var m in catalog._maskiner)
            {
                if (m.Name == SelectedName)
                {
                    _shared.Found = m;
                }
            }
        }

        public List<Equipment> FindEquipmentN()
        {
            List<Equipment> NList = new List<Equipment>();
            foreach (var m in catalog._maskiner)
            {
                if (m.Name == SelectedName)
                {
                    NList.Add(m);
                }
            }
            return NList;
        }
    }
}
