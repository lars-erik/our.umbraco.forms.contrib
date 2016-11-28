(function() {
    "use strict";

    angular.module("umbraco")
        .controller("umbracoformscontrib.richdisplayedtext.controller",
        [
            "$scope",
            function(scope) {
                scope.model = scope.setting;
                scope.model.config = {
                    editor: {
                        "toolbar": [
                          "code",
                          "formatselect",
                          "bold",
                          "italic",
                          "alignleft",
                          "aligncenter",
                          "alignright",
                          "bullist",
                          "numlist",
                          "link",
                          "umbmediapicker",
                          "charmap"
                        ],
                        "stylesheets": [
                        ],
                        "dimensions": {
                            "height": 400
                        },
                        "maxImageSize": 500
                    }
                };
            }
        ]);

}());