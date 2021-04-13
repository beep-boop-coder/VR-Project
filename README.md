# VR-Project
此程式是為了 VR for Good Challenge 的第二階段製作,使用的Unity版本為 2018.4.33f1

使用指南：

1. 在https://unity3d.com/get-unity/download 下載 Unity Hub，登入或註冊你的Unity 帳號，並啟用免費的個人版使用許可。

2. 打開 Unity Hub，在Installs > Add 中選擇 Unity 2018 年的 LTS (Long term support) 版本（暫時應為2018.4.33），並選擇加入 Android Build Support，最後按 Install，如下圖所示。

![image 8](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-8.png?raw=true)

3. 在https://github.com/beep-boop-coder/VR-Project 中按 Code > Download ZIP，以把本程式下載下來。

![image 2](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-2.png?raw=true)

4. 把下載的檔案解封，在 Unity Hub 的 Project > Open 中找 VR-Project-main > VR Project Prototype 並按 open。

![image 3](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-3.png?raw=true)

5. 在https://developer.android.com/studio 中下載 Android Studio。

6. 打開已下載的 Android Studio，去到 Configure > SDK Manager，並下載NDK，並確保SDK已下載，如下圖所示。

![image 4](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-4.png?raw=true)

7. 在 Android Studio 中打開 Configure > Default project structure，應見到以下畫面：

![image 5](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-5.png?raw=true)

8. 在剛打開的 2018 Unity 上方的選單列中打開 Unity > Preferences > external tools，並把剛才 Android Studio 找到的SDK 和 NDK 路徑抄上 Unity Preference 中的 SDK 和 NDK 欄位。

![image 6](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-6.png?raw=true)

9. 最後，在 Unity 上方的選單列中打開 File > Build Settings > Platform > Android，並按下方的 Switch Platform。等待轉換完成後，便可把 Oculus Go 裝置與電腦連結，再按 Build and Run，便可把軟件下載在 Oculus Go。

![image 7](https://github.com/beep-boop-coder/VR-Project/blob/main/README-images/image-7.png?raw=true)
