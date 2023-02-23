using Microsoft.AspNetCore.Components;
using PizzCore.Models;
using PizzBlazor.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzBlazor.Services;

namespace PizzBlazor.Pages
{
    public partial class PizzaComponent
    {
#nullable disable 
        [Inject]
        public IPizzaService PizzaService { get; set; }
#nullable enable
        private string? LoadingMessage { get; set; }
        private bool IsAdminMode { get; set; } = false;
        private Dictionary<Pizza, int> Cart { get; set; } = new Dictionary<Pizza, int>();
        private decimal Total => Cart.Sum(pizza => pizza.Key.Price * pizza.Value);
        private List<Pizza> PizzaList { get; set; } = new();
        private PizzaEditDTO? PizzaToEdit { get; set; } = null;
        private EditionModes EditionMode { get; set; }
        private enum EditionModes
        {
            Post,
            Put
        }
        protected override async Task OnInitializedAsync()
        {
            LoadingMessage = "Récupération des Pizzas...";
            PizzaList = await PizzaService.GetAll();
            LoadingMessage = "";
        }
        private void AddToCart(Pizza pizza)
        {
            if (Cart.ContainsKey(pizza))
                Cart[pizza]++;
            else
                Cart.Add(pizza, 1);
        }
        private void RemoveFromCart(Pizza pizza)
        {
            if (Cart[pizza] == 1)
                Cart.Remove(pizza);
            else
                Cart[pizza]--;
        }
        private void EmptyCart()
        {
            Cart.Clear();
        }
        private void EditPizza(Pizza pizza)
        {
            PizzaToEdit = new PizzaEditDTO()
            {
                Id = pizza.Id,
                IngredientsString = string.Join(",", pizza.Ingredients!),
                Name = pizza.Name,
                Price = pizza.Price,
            };
            EditionMode = EditionModes.Put;
        }
        private void AddPizza()
        {
            PizzaToEdit = new ();
            EditionMode = EditionModes.Post;
        }
        private async void DeletePizza(int id)
        {
            PizzaList.RemoveAll(p=> p.Id == id);
            await PizzaService.Delete(id);
        }
        private async Task SubmitPizza()
        {
            switch (EditionMode)
            {
                case EditionModes.Post:
                    var pizza2 = new Pizza()
                    {
                        Name = PizzaToEdit!.Name,
                        Price = PizzaToEdit.Price,
                        ImageLink = PizzaToEdit.ImageLink,
                        Ingredients = PizzaToEdit.IngredientsString!.Split(",")
                        .Select(ingredient => new Ingredient() { Name = ingredient.Trim() })
                        .ToList()
                    };
                    PizzaList.Add(pizza2);
                    await PizzaService.Post(pizza2);
                    break;
                case EditionModes.Put:
                    var pizza = PizzaList.Find(pizza => pizza.Id == PizzaToEdit!.Id)!;
                    pizza.Name = PizzaToEdit!.Name;
                    pizza.Price = PizzaToEdit.Price;
                    pizza.ImageLink = PizzaToEdit.ImageLink;
                    pizza.Ingredients = PizzaToEdit.IngredientsString!.Split(",")
                        .Select(ingredient => new Ingredient() { PizzaId = pizza.Id, Name = ingredient.Trim() })
                        .ToList();
                    await PizzaService.Put(pizza);
                    break;
                default:
                    break;
            }

            PizzaToEdit = null;
        }

    }
}
