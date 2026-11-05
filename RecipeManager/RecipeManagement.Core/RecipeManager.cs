using System;
using System.Collections.Generic;
using System.Linq;
using RecipeManagement.Core.Models;

namespace RecipeManagement.Core
{
    public class RecipeManager : IRecipeManager
    {
        private readonly Dictionary<Guid, Recipe> _recipes;
        private readonly List<Ingredient> _shoppingList;
        private readonly LinkedList<Recipe> _cookingPlan;
        private readonly Stack<Recipe> _removedRecipeUndoStack;
        private readonly Queue<Instruction> _cookingInstructionQueue;

        public int RecipeCount => _recipes.Count;
        public int ShoppingListItemCount => _shoppingList.Count;
        public int CookingPlanCount => _cookingPlan.Count;
        public int InstructionQueueCount => _cookingInstructionQueue.Count;

        public RecipeManager()
        {
            _recipes = new Dictionary<Guid, Recipe>();
            _shoppingList = new List<Ingredient>();
            _cookingPlan = new LinkedList<Recipe>();
            _removedRecipeUndoStack = new Stack<Recipe>();
            _cookingInstructionQueue = new Queue<Instruction>();
        }

        public RecipeManager(IEnumerable<Recipe> initialRecipes) : this()
        {
            if (initialRecipes == null) return;
            foreach (var r in initialRecipes)
            {
                if (!_recipes.ContainsKey(r.Id))
                {
                    _recipes[r.Id] = r;
                }
            }
        }

        public bool AddRecipe(Recipe recipe)
        {
            if (recipe == null) return false;
            if (_recipes.ContainsKey(recipe.Id)) return false;
            _recipes[recipe.Id] = recipe;
            return true;
        }

        public Recipe? FindRecipe(Guid id)
        {
            _recipes.TryGetValue(id, out var found);
            return found;
        }

        public bool RemoveRecipe(Guid id)
        {
            return _recipes.Remove(id);
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
