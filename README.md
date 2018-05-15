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

### 源代码地址

