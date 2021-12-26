namespace Singleton
{
    /*
     * Singleton has to be sealed.
     */
    public sealed class ThreadSafeSingleton
    {

        #region FIELD & PROPERTY

        /*
         * Still, this is the instance.
         */
        private static ThreadSafeSingleton _instance;

        /*
         * Different from the naive version,  We now have a lock object 
         * that will be used to synchronize threads in 1st access.
         */
        private static readonly object _lock = new object();

        /*
         * This property is for testing the thread-safe.
         */
        public string Text { get; set; }

        /*
         * private constructor
         */

        #endregion



        #region CONSTRUCTOR

        private ThreadSafeSingleton()
        {

        }

        #endregion



        #region MyRegion

        public static ThreadSafeSingleton GetInstance(string text)
        {
            /*
             * Now the program detect this instance is null
             */
            if (_instance == null)
            {
                /*
                 * Different from the naive version, the 1st thread found out
                 * the instance is null will LOCK this block. Therefore other
                 * threads found null will not enter. Once they are permitted
                 * to enter, the instance is not NULL anymore by the following.
                 */
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                        _instance.Text = text;  //put some input for testing
                    }
                }
            }

            return _instance;
        }

        #endregion

    }
}
