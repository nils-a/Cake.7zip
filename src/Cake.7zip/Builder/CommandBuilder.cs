namespace Cake.SevenZip
{
    /// <summary>
    /// Builder for all <see cref="ICommand"/>s.
    /// Do NOT call In...Mode() multiple times.
    /// </summary>
    public sealed class CommandBuilder
    {
        /// <summary>
        /// Gets or sets the Command.
        /// </summary>
        /// <value>
        /// The Command.
        /// </value>
        internal ICommand Command { get; set; }

        /// <summary>
        /// Makes this Builder an AddCommand-Builder.
        /// </summary>
        /// <returns><see cref="AddCommandBuilder"/>.</returns>
        public AddCommandBuilder InAddMode()
        {
            var command = new AddCommand();
            Command = command;
            return new AddCommandBuilder(ref command);
        }

        /// <summary>
        /// Makes this Builder an ExtractCommand-Builder.
        /// </summary>
        /// <returns><see cref="ExtractCommandBuilder"/>.</returns>
        public ExtractCommandBuilder InExtractMode()
        {
            var command = new ExtractCommand();
            Command = command;
            return new ExtractCommandBuilder(ref command);
        }

        /// <summary>
        /// Makes this Builder a DeleteCommand-Builder.
        /// </summary>
        /// <returns><see cref="ExtractCommandBuilder"/>.</returns>
        public DeleteCommandBuilder InDeleteMode()
        {
            var command = new DeleteCommand();
            Command = command;
            return new DeleteCommandBuilder(ref command);
        }

        /// <summary>
        /// Makes this Builder n UpdateCommand-Builder.
        /// </summary>
        /// <returns><see cref="ExtractCommandBuilder"/>.</returns>
        public UpdateCommandBuilder InUpdateMode()
        {
            var command = new UpdateCommand();
            Command = command;
            return new UpdateCommandBuilder(ref command);
        }
    }
}
