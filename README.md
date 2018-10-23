
# react-native-youmi

## Getting started

`$ npm install react-native-youmi --save`

### Mostly automatic installation

`$ react-native link react-native-youmi`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-youmi` and add `RNYoumi.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNYoumi.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNYoumiPackage;` to the imports at the top of the file
  - Add `new RNYoumiPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-youmi'
  	project(':react-native-youmi').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-youmi/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-youmi')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNYoumi.sln` in `node_modules/react-native-youmi/windows/RNYoumi.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Youmi.RNYoumi;` to the usings at the top of the file
  - Add `new RNYoumiPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNYoumi from 'react-native-youmi';

// TODO: What to do with the module?
RNYoumi;
```
  