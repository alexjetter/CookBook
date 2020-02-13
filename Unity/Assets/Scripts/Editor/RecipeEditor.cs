using UnityEditor;

[CustomEditor(typeof(Recipe))]
public class SocketZoneEditor : Editor
{

	private Recipe _target;

	void OnEnable()
	{
		_target = (Recipe)target;
	}

	public override void OnInspectorGUI()
	{
		foreach (RecipeIngredient ri in _target.Ingredients)
		{
			using (new EditorGUILayout.VerticalScope("box"))
			{
				//EditorGUILayout.TextField("Ingredient", ri.Ingredient.name);
				//EditorGUILayout.FloatField("Quantity", ri.Quantity);
				//EditorGUILayout.TextField("Unit", ri.Unit.name);

				//string str = ri.Quantity + " " + (ri.Quantity == 1 ? ri.Unit.Name : ri.Unit.NamePlural);
				string str = ri.Quantity + ((ri.Unit != null) ? " " + ri.Unit.Abbreviation : "");
				if (ri.PreStates != null)
				{
					foreach (IngredientState state in ri.PreStates)
					{
						if (state != null)
						{
							str += " " + state.name;
						}
					}
				}
				str += " " + ri.Ingredient.name;
				if (ri.PostStates != null)
				{
					foreach (IngredientState state  in ri.PostStates)
					{
						if (state != null)
						{
							str += ", " + state.Name;
						}
					}
				}
				EditorGUILayout.LabelField(str);
			}
		}

		DrawDefaultInspector();

		// serializedObject.Update();

		// serializedObject.ApplyModifiedProperties();
	}
}