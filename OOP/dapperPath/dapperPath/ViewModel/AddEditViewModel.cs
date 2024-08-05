using dapperPath.Model;
using dapperPath.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;


namespace dapperPath.ViewModel
{

    public class AddEditViewModel : ViewModelBase
    {
        public ICommand NavigateBackCommand { get; }
        public ICommand SaveBootsCommand { get; }
        public ICommand OpenDialog { get; }
        private Shoes _currentShoes = new Shoes();


        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        private string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
                RaisePropertyChanged(nameof(Brand));
            }
        }

        private string _avaibilitySizes;
        public string AvaibilitySizes
        {
            get { return _avaibilitySizes; }
            set
            {
                _avaibilitySizes = value;
                RaisePropertyChanged(nameof(AvaibilitySizes));
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }

        private string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                RaisePropertyChanged(nameof(Image));
            }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                RaisePropertyChanged(nameof(Price));
            }
        }

        private string _sex;
        public string Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                RaisePropertyChanged(nameof(Sex));
            }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
                RaisePropertyChanged(nameof(Category));
            }
        }
        JsonManager manager = new JsonManager("D:\\Desktop\\labs\\OOP\\dapperPath\\dapperPath\\Resourses\\shoes.json");
        public AddEditViewModel( Shoes selectedItem)
        {
            if (selectedItem != null)
            {
                _currentShoes = new Shoes
                {
                    ProductID = selectedItem.ProductID,
                    Title = selectedItem.Title,
                    Brand = selectedItem.Brand,
                    AvailableSizes = selectedItem.AvailableSizes,
                    Description = selectedItem.Description,
                    Image = selectedItem.Image,
                    Price = selectedItem.Price,
                    Sex = selectedItem.Sex,
                    Category = selectedItem.Category
                };
                Title = selectedItem.Title;
                Brand = selectedItem.Brand;
                AvaibilitySizes = selectedItem.AvailableSizes;
                Description = selectedItem.Description;
                Image = selectedItem.Image;
                Price = (decimal)selectedItem.Price;
                Sex = selectedItem.Sex;
                Category = selectedItem.Category;
            }
            else
            {
                _currentShoes = new Shoes();
            }
            OpenDialog = new RelayCommand(OpenDialogFile);
            SaveBootsCommand = new RelayCommand(SaveBoots);
            NavigateBackCommand = new RelayCommand(Back);
        }
        private void Back()
        {
            CustomNavigate.GoBack();
        }
 
        public void SaveBoots()
        {
            _currentShoes.Title = Title;
            _currentShoes.Brand = Brand;
            _currentShoes.AvailableSizes = AvaibilitySizes;
            _currentShoes.Description = Description;
            _currentShoes.Image = Image;
            _currentShoes.Price = Price;
            _currentShoes.Sex = Sex;
            _currentShoes.Category = Category;

            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentShoes.Title))
            {
                error.AppendLine("Укажите название пары");
            }
            if (string.IsNullOrWhiteSpace(_currentShoes.Brand))
            {
                error.AppendLine("Укажите бренд пары");
            }
            if (string.IsNullOrWhiteSpace(_currentShoes.Description))
            {
                error.AppendLine("Укажите описание пары");
            }
            if (string.IsNullOrWhiteSpace(_currentShoes.Category))
            {
                error.AppendLine("Укажите категорию пары");
            }
            if (string.IsNullOrWhiteSpace(_currentShoes.Price.ToString()))
            {
                error.AppendLine("Укажите цену пары");
            }
            if (string.IsNullOrWhiteSpace(_currentShoes.Sex))
            {
                error.AppendLine("Укажите пол целевого покупателя");
            }

            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            

                List<Shoes> jsonShoes = manager.Deserialize();
                jsonShoes.RemoveAll(s => s.Title == _currentShoes.Title);
                jsonShoes.Add(_currentShoes);
                manager.Clear();
                foreach (var item in jsonShoes)
                {
                    manager.Serialize(item);
                }
                MessageBox.Show("Информация сохранена");
                CustomNavigate.GoBack();
                ShoesViewModel.Instance.RefreshShoes();

            

               
               
            
        }
        private void OpenDialogFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png, *.jpg, *.jpeg, *.gif, *.webp) | *.png; *.jpg; *.jpeg; *.gif;*.webp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                Image = openFileDialog.FileName;
            }
        }

        
    }
}
