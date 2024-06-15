using ANToolkit;
using ANToolkit.Controllers; 
using ANToolkit.Level;
using Asuna.CharManagement;
using Asuna.Dialogues;
using Modding;
using System.Linq.Expressions;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

namespace TCModExample
{
    public class TCModExample : ITCMod
    {
        public void OnDialogueStarted(Dialogue dialogue)
        {
            Debug.Log("Modded OnDialogueStarted");
        }

        public void OnFrame(float deltaTime)
        {

        }

        public void OnLevelChanged(string oldLevel, string newLevel)
        {
            Debug.Log("Modded OnLevelChanged");
        }

        public void OnLineStarted(DialogueLine line)
        {
            Debug.Log("Modded OnLineStarted");
        }

        public void OnModLoaded(ModManifest manifest)
        {
            Debug.Log("Modded OnModLoaded");

            AddTrigger();
        }

        public void OnModUnLoaded()
        {
            Debug.Log("Modded OnModUnLoaded");
        }

        private void GenerateDialogue()
        {
            var character = Character.Get("Jenna");
            var expression = character.GetPresetExpressionID(PresetExpression.Idle);

            var newLine = new DialogueLine()
            {
                LineID = "line_0",
                Text = "Hey I'm a modded Dialogue! 2",
                NameOverride = "",
                Speaker = "",
                Character = character,
                TextColor = Color.white,
                NextID = "",
                DisplaySpriteInTextbox = true,
                BrowExpression = expression,
                EyeExpression = expression,
                MouthExpression = expression
            };


            var generatedDialogue = ScriptableObject.CreateInstance<Dialogue>();
            generatedDialogue.Lines.Add(newLine);

            DialogueManager.StartDialogue(generatedDialogue);
        }

        private void AddTrigger()
        {
            var triggerGameObject = new GameObject();
            triggerGameObject.transform.position = new Vector3(4f, 0f, 0f);

            var triggerBox = triggerGameObject.AddComponent<BoxCollider>();
            triggerBox.isTrigger = true;
            triggerBox.size = new Vector3(2f, 2f);

            var trigger = triggerGameObject.AddComponent<Trigger>();
            trigger.OnlyTriggerPlayer = true;
            trigger.MustBeEntirelyInside = false;
            trigger.OnEnter.AddListener(OnTriggerEntered);
        }

        private void OnTriggerEntered(Collider other)
        {
            GenerateDialogue();
        }
    }
}
