namespace Singleton
{
    public sealed class NoLockThreadSafeSingleton
    {
        #region FIELD & PROPERTY

        private static readonly NoLockThreadSafeSingleton _instance = new NoLockThreadSafeSingleton();

        public static NoLockThreadSafeSingleton Instance
        {
            get
            {
                return _instance;
            }
        }

        public string Text { get; set; }

        #endregion



        #region CONSTRUCTOR

        /*
         * Explicit static constructor to tell C# compiler
         * not to mark type as before field init
         */
        static NoLockThreadSafeSingleton()
        {

        }

        private NoLockThreadSafeSingleton()
        {

        }

        #endregion



        #region METHOD

        #endregion
    }
}
