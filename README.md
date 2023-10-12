# MAUI

The app was created using a the Visual Studio new MAui Project

#### Problem

When the Android App is opened via Deep Link, the NavigationPage.TitleView and the ToolbarItems are gone.

#### Steps To Reproduce:

1. Run the Android Application on a Android Emulator
2. Use deeplink to start the app

On windows machine, the following command can be used to open the application view deep link

> adb shell am start -d "DeepLink://TitleIssue"

##### Observed Behavior
 
 1. The Title View on MainPage is not shown
 2. The ToolbarItems are also not shown

#### Expected Behavior

The page should be same as before deeplinking.
