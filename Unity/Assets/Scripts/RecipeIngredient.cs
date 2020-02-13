using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RecipeIngredient
{
	public string Name;
	public Ingredient Ingredient;
	public float Quantity;
	public MeasurementUnit Unit;
	public IngredientState[] PreStates;
	public IngredientState[] PostStates;

}