using UnityEngine;
using UnityEditor;

/// <summary>
/// Check out http://diegogiacomelli.com.br/unitytips-hierarchy-window-group-header/
/// </summary>

namespace Utils.Editor
{
    [InitializeOnLoad]
    public class HierarchyLabel : MonoBehaviour
    {
        static HierarchyLabel()
        {
            EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;
        }

        static void HierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
        {
            GameObject label = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

            if (label != null)
            {
                if (label.name.StartsWith("---", System.StringComparison.Ordinal))
                {
                    EditorGUI.DrawRect(selectionRect, Color.grey);
                    EditorGUI.DropShadowLabel(selectionRect, label.name.Replace("-", "").ToString());
                } 
                else if (label.name.StartsWith("!!!", System.StringComparison.Ordinal))
                {
                    EditorGUI.DrawRect(selectionRect, Color.red);
                    EditorGUI.DropShadowLabel(selectionRect, label.name.Replace("!", "").ToString());
                } 
                else if (label.name.StartsWith("###", System.StringComparison.Ordinal))
                {
                    EditorGUI.DrawRect(selectionRect, Color.blue);
                    EditorGUI.DropShadowLabel(selectionRect, label.name.Replace("#", "").ToString());
                }
            }
        }
    }
}