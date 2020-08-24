using DAN_LV_Dejan_Prodanovic.Command;
using DAN_LV_Dejan_Prodanovic.DataAcces;
using DAN_LV_Dejan_Prodanovic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DAN_LV_Dejan_Prodanovic.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        MainWindow view;
        IngredientData ingredientData;

        public bool orderPerformed = false;
        int counter = 0;

        public MainViewModel(MainWindow mainView)
        {
            view = mainView;
           
                   
            ingredientsList = new List<Ingredient>();
            ingredientData = new IngredientData();
        }

        

        private List<Ingredient> ingredientsList;
      
               
        private ICommand close;
        public ICommand Close
        {
            get
            {
                if (close == null)
                {
                    close = new RelayCommand(param => CloseExecute(), param => CanCloseExecute());
                }
                return close;
            }
        }
        private void CloseExecute()
        {
            try
            {
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex.Message.ToString());
            }
        }
        private bool CanCloseExecute()
        {
            return true;
        }

       

        private bool salami;

        public bool Salami
        {
            get { return salami; }
            set
            {
                salami = value;
                OnPropertyChanged("Salami");
            }
        }


        private bool ham;

        public bool Ham
        {
            get { return ham; }
            set
            {
                ham = value;
                OnPropertyChanged("Ham");
            }
        }

        private bool kulen;

        public bool Kulen
        {
            get { return kulen; }
            set
            {
                kulen = value;
                OnPropertyChanged("Kulen");
            }
        }

        private bool ketchup;

        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                OnPropertyChanged("Ketchup");
            }
        }

        private bool mayo;

        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                OnPropertyChanged("Mayo");
            }
        }

        private bool chilliPaper;

        public bool ChilliPaper
        {
            get { return chilliPaper; }
            set
            {
                chilliPaper = value;
                OnPropertyChanged("ChilliPaper");
            }
        }

        private bool olives;

        public bool Olives
        {
            get { return olives; }
            set
            {
                olives = value;
                OnPropertyChanged("Olives");
            }
        }
        private bool oregano;

        public bool Oregano
        {
            get { return oregano; }
            set
            {
                oregano = value;
                OnPropertyChanged("Oregano");
            }
        }

        private bool sesame;

        public bool Sesame
        {
            get { return sesame; }
            set
            {
                sesame = value;
                OnPropertyChanged("Sesame");
            }
        }

        private bool cheese;

        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                OnPropertyChanged("Cheese");
            }
        }

        private ICommand subbmit;
        public ICommand Subbmit
        {
            get
            {
                if (subbmit == null)
                {
                    subbmit = new RelayCommand(param => SubbmitExecute(), param => CanSubbmitExecute());
                }
                return subbmit;
            }
        }

        private void SubbmitExecute()
        {
            try
            {
                Ingredient ingredient;

                if (Salami == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Salami");
                    if (ingredient!=null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Ham == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Ham");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Mayo == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Mayo");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Kulen == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Kulen");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Ketchup == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Ketchup");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                 
                if (ChilliPaper == true)
                {
                    ingredient = ingredientData.GetIngredientByName("ChilliPaper");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Olives == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Olives");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Oregano == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Oregano");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Sesame == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Sesame");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }
                if (Cheese == true)
                {
                    ingredient = ingredientData.GetIngredientByName("Cheese");
                    if (ingredient != null)
                    {
                        ingredientsList.Add(ingredient);
                    }
                }

                orderPerformed = true;
                foreach (var item in ingredientsList)
                {
                    MessageBox.Show(item.Name);
                }
              


                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private bool CanSubbmitExecute()
        {
            if (counter>=3 && orderPerformed == false)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }


        private ICommand newOrder;
        public ICommand NewOrder
        {
            get
            {
                if (newOrder == null)
                {
                    newOrder = new RelayCommand(param => NewOrderExecute(),
                        param => CanNewOrderExecute());
                }
                return newOrder;
            }
        }

        private void NewOrderExecute()
        {
            try
            {

                

                orderPerformed = true;
                



            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private bool CanNewOrderExecute()
        {
            if (orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private ICommand chooseHam;
        public ICommand ChooseHam
        {
            get
            {
                if (chooseHam == null)
                {
                    chooseHam = new RelayCommand(ChooseHamExecute, CanChooseHamExecute);
                }
                return chooseHam;
            }
        }

        private void ChooseHamExecute(object parameter)
        {
            
            Ham = (bool)parameter;
            if (Ham == true)
            {
                counter++;
              
            }
            else if (Ham == false)
            {
                counter--;
                
            }
        }

        private bool CanChooseHamExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }
               
        }


        private ICommand chooseSalami;
        public ICommand ChooseSalami
        {
            get
            {
                if (chooseSalami == null)
                {
                    chooseSalami = new RelayCommand(ChooseSalamiExecute,
                        CanChooseSalamiExecute);
                }
                return chooseSalami;
            }
        }

        private void ChooseSalamiExecute(object parameter)
        {

            Salami = (bool)parameter;
            if (Salami == true)
            {
                counter++;
               
            }
            else if (Salami == false)
            {
                counter--;
               
            }
        }

        private bool CanChooseSalamiExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseKulen;
        public ICommand ChooseKulen
        {
            get
            {
                if (chooseKulen == null)
                {
                    chooseKulen = new RelayCommand(ChooseKulenExecute,
                        CanChooseKulenExecute);
                }
                return chooseKulen;
            }
        }

        private void ChooseKulenExecute(object parameter)
        {

            Kulen = (bool)parameter;
            if (Kulen == true)
            {
                counter++;

            }
            else if (Kulen == false)
            {
                counter--;

            }
        }

        private bool CanChooseKulenExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseKetchup;
        public ICommand ChooseKetchup
        {
            get
            {
                if (chooseKetchup == null)
                {
                    chooseKetchup = new RelayCommand(ChooseKetchupExecute,
                        CanChooseKetchupExecute);
                }
                return chooseKetchup;
            }
        }

        private void ChooseKetchupExecute(object parameter)
        {

            Ketchup = (bool)parameter;
            if (Ketchup == true)
            {
                counter++;

            }
            else if (Ketchup == false)
            {
                counter--;

            }
        }

        private bool CanChooseKetchupExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseMayonnaise;
        public ICommand ChooseMayonnaise
        {
            get
            {
                if (chooseMayonnaise == null)
                {
                    chooseMayonnaise = new RelayCommand(ChooseMayonnaiseExecute,
                        CanChooseMayonnaiseExecute);
                }
                return chooseMayonnaise;
            }
        }

        private void ChooseMayonnaiseExecute(object parameter)
        {

            Mayo = (bool)parameter;
            if (Mayo == true)
            {
                counter++;

            }
            else if (Mayo == false)
            {
                counter--;

            }
        }

        private bool CanChooseMayonnaiseExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseChilliPaper;
        public ICommand ChooseChilliPaper
        {
            get
            {
                if (chooseChilliPaper == null)
                {
                    chooseChilliPaper = new RelayCommand(ChooseChilliPaperExecute,
                        CanChooseChilliPaperExecute);
                }
                return chooseChilliPaper;
            }
        }

        private void ChooseChilliPaperExecute(object parameter)
        {

            ChilliPaper = (bool)parameter;
            if (ChilliPaper == true)
            {
                counter++;

            }
            else if (ChilliPaper == false)
            {
                counter--;

            }
        }

        private bool CanChooseChilliPaperExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseOlives;
        public ICommand ChooseOlives
        {
            get
            {
                if (chooseOlives == null)
                {
                    chooseOlives = new RelayCommand(ChooseOlivesExecute,
                        CanChooseOlivesExecute);
                }
                return chooseOlives;
            }
        }

        private void ChooseOlivesExecute(object parameter)
        {

            Olives = (bool)parameter;
            if (Olives == true)
            {
                counter++;

            }
            else if (Olives == false)
            {
                counter--;

            }
        }

        private bool CanChooseOlivesExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseOregano;
        public ICommand ChooseOregano
        {
            get
            {
                if (chooseOregano == null)
                {
                    chooseOregano = new RelayCommand(ChooseOreganoExecute,
                        CanChooseOreganoExecute);
                }
                return chooseOregano;
            }
        }

        private void ChooseOreganoExecute(object parameter)
        {

            Oregano = (bool)parameter;
            if (Oregano == true)
            {
                counter++;

            }
            else if (Oregano == false)
            {
                counter--;

            }
        }

        private bool CanChooseOreganoExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseSesame;
        public ICommand ChooseSesame
        {
            get
            {
                if (chooseSesame == null)
                {
                    chooseSesame = new RelayCommand(ChooseSesameExecute,
                        CanChooseSesameExecute);
                }
                return chooseSesame;
            }
        }

        private void ChooseSesameExecute(object parameter)
        {

            Sesame = (bool)parameter;
            if (Sesame == true)
            {
                counter++;

            }
            else if (Sesame == false)
            {
                counter--;

            }
        }

        private bool CanChooseSesameExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private ICommand chooseCheese;
        public ICommand ChooseCheese
        {
            get
            {
                if (chooseCheese == null)
                {
                    chooseCheese = new RelayCommand(ChooseCheeseExecute,
                        CanChooseCheeseExecute);
                }
                return chooseCheese;
            }
        }

        private void ChooseCheeseExecute(object parameter)
        {

            Sesame = (bool)parameter;
            if (Cheese == true)
            {
                counter++;

            }
            else if (Cheese == false)
            {
                counter--;

            }
        }

        private bool CanChooseCheeseExecute(object parameter)
        {
            if (!orderPerformed)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
