using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Recipe", order = 2)]
public class Recipe : ScriptableObject
{
	public Ingredient ResultItem;
	public RecipeIngredient[] Ingredients;
	public Stage[] Stages;
}
