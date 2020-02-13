using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Step
{
	public string Action;
	public RecipeIngredient[] Ingredients;
	public Tool[] Tools;
	public int Duration;
	public MeasurementUnit TimeUnit;
}