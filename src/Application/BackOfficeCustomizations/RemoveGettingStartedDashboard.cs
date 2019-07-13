namespace Application.BackOfficeCustomization
{

    // Namespaces.
    using Umbraco.Core;
    using Umbraco.Core.Composing;
    using Umbraco.Web;
    using Umbraco.Web.Dashboards;

    /// <summary>
    /// A composer that removes the "Getting Started" dashboard in the content section.
    /// </summary>
    /// <remarks>
    /// Based upon code from this example: https://our.umbraco.com/documentation/Extending/Dashboards/#remove-an-umbraco-dashboard
    /// </remarks>
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class RemoveGettingStartedDashboard : IUserComposer
    {

        #region Methods

        /// <summary>
        /// Primary method that contains the functionality to remove the dashboard.
        /// </summary>
        /// <param name="composition">
        /// The composition to use to remove the dashboard.
        /// </param>
        public void Compose(Composition composition)
        {
            composition.Dashboards().Remove<ContentDashboard>();
        }

        #endregion

    }

}