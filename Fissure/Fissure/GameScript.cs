using Microsoft.Scripting.Hosting;

namespace Fissure
{
    public class GameScript<T> : IGameScript<T>
    {
        private GameState _gameState;
        private ScriptEngine _engine;
        private string _scriptText;

        public GameScript(GameState gameState, ScriptEngine engine, string scriptText)
        {
            _gameState = gameState;
            _engine = engine;
            _scriptText = scriptText;
        }

        public T Evaluate()
        {
            ScriptScope scope = _engine.CreateScope();
            scope.SetVariable("GameState", _gameState);
            return (T) _engine.Execute(_scriptText, scope);
        }
    }
}
