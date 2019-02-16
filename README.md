# RentCar

Application to handle the process of lending cars in RentCar businesses.

## Table of Contents

1. [Getting Started](#GettingStarted)
1. [Prerequisites](#Prerequisites)

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. 

### Prerequisites

When you download the project you will need to create two file in the main directory of the project RentCar.App, one will be named `PrivateSettings.config` and the other SmtpSettings.config, these files contain private information that can not upload to the repository, it is for this reason which are locked in the .gitignore file and therefore when you download the project for the first time you have to create it. These files to date should have the following information and structure:

**PrivateSettings.config**
```
<appSettings>
  <add key="Twilio_ACCOUNTSID" value="{{value}}"/>
  <add key="Twilio_AUTHTOKEN" value="{{value}}"/>
  <add key="Twilio_PHONENUMBER" value="{{value}}"/>
</appSettings>
```

**SmtpSettings.config**
```
<smtp from="{{value}}">
  <network host="{{value}}"
         port="{{value}}"
         defaultCredentials="{{value}}"
         enableSsl="{{value}}"
         userName="{{value}}"
         password ="{{value}}" />
</smtp>
```

These two files are needed by the App.config for its correct operation in the following lines:

```
  <appSettings file="PrivateSettings.config"></appSettings>
  <system.net>
    <mailSettings>
      <smtp configSource="SmtpSettings.config"></smtp>
    </mailSettings>
  </system.net>
```
