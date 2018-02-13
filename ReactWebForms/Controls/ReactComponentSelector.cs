using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using React;

[assembly: TagPrefix("ReactWebForms.Controls", "ReactWebForms")]
namespace ReactWebForms.Controls
{

    public enum ComponentNameEnum { HelloWorld, HelloWorld2, ReactImage }


    [DefaultProperty("ReactImageName")]
    [ToolboxData("<{0}:ReactComponentSelector runat=server></{0}:ReactComponentSelector>")]
    public class ReactComponentSelector : WebControl
    {

        public ComponentNameEnum ComponentName { get; set; }
        public string ReactImageName { get; set; }

        public string HelloWorldUserName { get; set; }


        protected override void RenderContents(HtmlTextWriter output)
        {


            //### We are rendering React components to a Literal on ReactComponent.ascx
            //multiple compoents can be rendered from here.

            //render react components
            var env = AssemblyRegistration.Container.Resolve<IReactEnvironment>();
            IReactComponent reactComponent = null;

            switch (this.ComponentName)
            {
                case ComponentNameEnum.HelloWorld:
                    //set componet properties
                    var objectModel = new { user =  HelloWorldUserName };
                    //Get Hello World Component
                    reactComponent = env.CreateComponent("PageContent", objectModel);
                    break;
                case ComponentNameEnum.HelloWorld2:
                    //set componet properties
                    var objectModel_helloWorld2 = new { name = HelloWorldUserName };
                    //Get Hello World Component
                    reactComponent = env.CreateComponent("HelloWorld2", objectModel_helloWorld2);
                    break;
                case ComponentNameEnum.ReactImage:
                    //set componet properties
                    var objectModel_reactImage = new { imageName = ReactImageName };
                    //Get ReactImage Component
                    reactComponent = env.CreateComponent("ReactImage", objectModel_reactImage, "imageDiv");
                    break;
              
            }

            if ((env != null) && (reactComponent != null))
            {
                //render                 
                output.Write(reactComponent.RenderHtml());
            }

        }
    }
}
