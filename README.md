## JPush插件
#### 插件说明：
集成极光推送

#### 方法：
|方法|方法说明|
|:-|:-| 
|Push|向指定别名推送消息（应用弹出）|
|PushAll  |向全部设备推送消息（应用弹出）|
|PushBigText  |向指定别名推送大文本|
|PushBigTextAll  |向全部设备推送大文本|
|PushAlert  |向指定别名推送通知（抬头栏）|
|PushAlertAll  |向全部设备推送通知（抬头栏）|
|PushURL  |向指定别名推送点击跳转URL链接的消息|
|PushURLAll  |向全部设备推送点击跳转URL链接的消息|
|PushClientCallBack|向指定别名推送点击触发客户端回调的消息|
|PushClientCallBackAll|向全部设备推送点击触发客户端回调的消息|
|SetMessage|设置Message|

设置别名 this.Client.Push.SetAlias()

### 注意事项
* 极光推送由于需要打包极光Key，所以必须在使用打包版本（如何打包详见 https://www.smobiler.com/yunapp.aspx ）
* 去极光推送官网注册应用时（请注意，注册的应用后，设置推送时，**android的包名必须要和云平台上的应用的包名一致**）
* 极光推送必须要公网可访问（如果服务端和客户端都在内网，不能使用极光推送）


### 源代码地址

