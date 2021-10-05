# How-to-track-usage-and-crashes-in-Xamarin.Forms-Application-using-AppCenter

Integrating AppCenter SDK in Xamarin.Forms application enables to track the analytics as well as the crashes which helps to understand the customer usage and for further improvement. It will automatically send crash reports, track sessions and collect device info like OS Version, model, etc. AppCenter SDK integration in Xamarin project is too simple as riding a bicycle. 

**First** step is to create an account in [AppCenter portal](https://appcenter.ms/), as the integration requires a unique key in every platform.
**Second** step involves creating new app in portal. Though the development is via cross platform framework, analytics and distribution in stores like AppStore or PlayStore or Microsoft store requires individual applications. So create a separate app for each platform. Apps created will be displayed in the dashboard like below.
![image](https://user-images.githubusercontent.com/26808947/136053999-e9a50514-c597-49b7-9a84-3ae790e507c6.png)

That's it from the point of AppCenter. Now let's move to Xamarin App.

**First step** in application involves installing necessary packages. Install the latest version(v4.4.0 as of publishing) of **Microsoft.AppCenter.Analytics** and **Microsoft.AppCenter.Crashes** in PCL as well as the renderer projects(Android, iOS and UWP).
**Second Step** involves registering the unique key which is generated while creating the applications in AppCenter. Add the namespace and start the AppCenter by passing the unique key.

```
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

public App()
{
    InitializeComponent();
    AppCenter.Start("android={Your App SecretID};" +
          "uwp={Your App SecretID};" +
          "ios={Your App SecretID}",
          typeof(Analytics), typeof(Crashes));
    MainPage = new MainPage();
}
```

That would be all! Since the report will be automatically generated and sent to AppCenter, no additional codes required.

Analytics tab reports the session duration, device info and number of active device related info.
![image](https://user-images.githubusercontent.com/26808947/136056534-10fbbd80-ec47-44c0-b9af-4f64a3c12d86.png)

Diagnostics tab groups the crash reports with call stack details.
![image](https://user-images.githubusercontent.com/26808947/136056923-d6e34c2c-62eb-4034-9fae-7841e945b531.png)

You can make use of the metrics and improvise the published apps. You can also refer to below documentation for detailed explanation.
https://docs.microsoft.com/en-us/appcenter/sdk/getting-started/xamarin
