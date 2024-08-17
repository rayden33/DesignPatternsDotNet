namespace Structural.Composite
{
    public class GameSceneService
    {
        private List<GameObject> _sceneGameObjects;

        public GameSceneService()
        {
            _sceneGameObjects = new List<GameObject>();
        }

        public void AddGameObjectToScene(GameObject gameObject) => _sceneGameObjects.Add(gameObject);
        public void RemoveGameObjectFromScene(GameObject gameObject) => _sceneGameObjects.Remove(gameObject);

    }
}