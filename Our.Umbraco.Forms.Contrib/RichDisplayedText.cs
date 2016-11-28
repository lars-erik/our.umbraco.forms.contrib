using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Attributes;

namespace Our.Umbraco.Forms.Contrib
{
    /*
/App_Plugins/UmbracoForms/Backoffice/Common/FieldTypes/RichDisplayedText.html 
~/App_Plugins/UmbracoFormsContrib/Backoffice/Common/FieldTypes/richdisplayedtext.html
 * * */

    public class RichDisplayedText : FieldType
    {
        [Setting("Headline", description = "Enter a Headline")]
        public string Caption { get; set; }

        [Setting(
            "Body Text", 
            description = "Enter your copy text", 
            view="~/App_Plugins/UmbracoFormsContrib/Backoffice/Common/SettingTypes/richdisplayedtext.html"
            )]
        public string BodyText { get; set; }

        public RichDisplayedText()
        {
            this.Id = new Guid("8084BABD-54BA-446E-9C4A-B24DFA707B17");
            this.Name = "Title and rich description";
            this.Description = "This is used to enter some descriptive text";

            this.Icon = "icon-edit";
            this.DataType = FieldDataType.String;

            this.Category = "Simple";
            this.SortOrder = 110;
        }

        public override string GetDesignView()
        {
            return "~/App_Plugins/UmbracoFormsContrib/Backoffice/Common/FieldTypes/richdisplayedtext.html";
        }

        public override bool HideLabel
        {
            get
            {
                return true;
            }
        }

        public override bool StoresData
        {
            get
            {
                return false;
            }
        }
    }
}
