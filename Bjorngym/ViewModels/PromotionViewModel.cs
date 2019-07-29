using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Bjorngym.Models;
using Xamarin.Forms;

namespace Bjorngym.ViewModels
{
    public class PromotionViewModel : BaseViewModel
    {
        public ObservableCollection<Promotion> Promotions { get; set; }
        public Command LoadItemsCommand { get; set; }

        public PromotionViewModel()
        {
            Promotions = new ObservableCollection<Promotion>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Promotions.Clear();
                var promotions = new List<Promotion>()
                {
                    new Promotion(){ Id = 1, Name = "Promoção de Verão", Title = "Promoção de Verão", ShortDescription = "Musculação mensal, qualquer dia e horário por apenas R$ 69,90…", Description ="Musculação mensal, qualquer dia e horário por apenas R$ 69,90.", UrlImage="summerpromotion"},
                    new Promotion(){ Id = 2, Name = "Suplementação", Title = "Promoção de Suplementos", ShortDescription = "Marcas nacionais e internacionais pelo melhor preço...", Description ="Marcas nacionais e internacionais pelo melhor preço", UrlImage="suplementpromotion"},
                };
                foreach (var item in promotions)
                {
                    Promotions.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
