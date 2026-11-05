using System;
using System.Collections.Generic;
using System.Linq;
using RecipeManagement.Core.Models;

namespace RecipeManagement.Core
{
    public class RecipeManager : IRecipeManager
    {
        public int RecipeCount { get; }
        public int ShoppingListItemCount { get; }
        public int CookingPlanCount { get; }
        public int InstructionQueueCount { get; }

        public RecipeManager()
        {
        }

        public RecipeManager(IEnumerable<Recipe> initialRecipes)
        {
        }

        public bool AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Recipe? FindRecipe(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRecipe(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddIngredientsToShoppingList(IEnumerable<Ingredient> ingredients)
        {
            throw new NotImplementedException();
        }

        public List<Ingredient> GetShoppingList()
        {
            throw new NotImplementedException();
        }

        public void ClearShoppingList()
        {
            throw new NotImplementedException();
        }

        public bool AddRecipeToCookingPlan(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRecipeFromCookingPlan()
        {
            throw new NotImplementedException();
        }

        public Recipe? PeekLastRemovedRecipe()
        {
            throw new NotImplementedException();
        }

        public bool RestoreLastRemovedRecipe()
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetCookingPlan()
        {
            throw new NotImplementedException();
        }

        public bool StartCooking(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public Instruction? PeekNextInstruction()
        {
            throw new NotImplementedException();
        }

        public bool CompleteNextInstruction()
        {
            throw new NotImplementedException();
        }

        // Part B methods, leave untouched for now
        public List<Recipe> SearchByName(string keyword)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> SearchByIngredient(string ingredientName)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> SortByProteinContent(bool ascending)
        {
            throw new NotImplementedException();
        }

        public bool AddFavourite(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveFavourite(Guid recipeId)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetFavourites()
        {
            throw new NotImplementedException();
        }
    }
}

