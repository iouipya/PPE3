﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPE3_Daltons.Helper_Classes;
using PPE3_Daltons.API_Daltons;
using System.Collections.ObjectModel;
using PPE3_Daltons.Company.Main_Societe;

namespace PPE3_Daltons.Company.Compte_rendu_Societe
{
    public class CompteRenduSocieteViewModel : ObservableObject, IPageViewModel
    {
        private IList<Compte_rendu> compte_rendu = null;

        private MainSocieteViewModel mainSocieteViewModel;

        private ObservableCollection<Compte_rendu> data;

        private API_Daltons.Compte_rendu currentCompte_rendu;

        private int id_compte_rendu;

        private int id_technicien;

        private int id_societe;

        private int id_intervention;

        private string note;

        public CompteRenduSocieteViewModel()
        {
            CurrentCompte_rendu = new Compte_rendu();
        }

        public string Name
        {
            get { return "Compte_rendu Societe"; }
        }

        public IList<Compte_rendu> Data
        {
            get
            {

                data = new ObservableCollection<Compte_rendu>(SearchCompte_RenduBase());
                return data;

            }
        }

        public IList<Compte_rendu> Compte_rendu
        {
            get
            {
                compte_rendu = SearchCompte_RenduBase();
                return this.compte_rendu;
            }

            set
            {
                if (this.compte_rendu == value)
                {
                    return;
                }
                this.compte_rendu = value;
            }
        }

        public API_Daltons.Compte_rendu CurrentCompte_rendu
        {
            get
            {
                return this.currentCompte_rendu;
            }

            set
            {
                if (this.currentCompte_rendu == value)
                {
                    return;
                }
                this.currentCompte_rendu = value;
            }
        }

        public MainSocieteViewModel MainSocieteViewModel
        {
            get
            {
                return this.mainSocieteViewModel;
            }

            set
            {
                if (this.mainSocieteViewModel == value)
                {
                    return;
                }
                this.mainSocieteViewModel = value;
            }
        }

        public int Id_compte_rendu
        {
            get
            {
                return this.id_compte_rendu;
            }

            set
            {
                if (this.id_compte_rendu == value)
                {
                    return;
                }
                this.id_compte_rendu = value;
            }
        }

        public int Id_technicien
        {
            get
            {
                return this.id_technicien;
            }

            set
            {
                if (this.id_technicien == value)
                {
                    return;
                }
                this.id_technicien = value;
            }
        }

        public int Id_societe
        {
            get
            {
                return this.id_societe;
            }

            set
            {
                if (this.id_societe == value)
                {
                    return;
                }
                this.id_societe = value;
            }
        }

        public int Id_intervention
        {
            get
            {
                return this.id_intervention;
            }

            set
            {
                if (this.id_intervention == value)
                {
                    return;
                }
                this.id_intervention = value;
            }
        }

        public string Note
        {
            get
            {
                return this.note;
            }

            set
            {
                if (this.note == value)
                {
                    return;
                }
                this.note = value;
            }
        }

        private IList<Compte_rendu> SearchCompte_RenduBase()
        {

            Compte_rendu compte_rendus = new Compte_rendu();
            compte_rendus.note = "";

            IList<Compte_rendu> ListCompte_rendu = null;
            using (API_Daltons.Service1Client api = new API_Daltons.Service1Client())
            {
                {
                    ListCompte_rendu = api.SearchCompte_rendu();
                }
            }
            return ListCompte_rendu;

        }
    }
}
