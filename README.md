﻿JdSdk
=====

京东开放平台.NET版sdk 

[最新版下载](https://github.com/starpeng/JdSdk/raw/master/Releases/JdSdk.NET%201.2.0.zip "1.2.0")

[问题反馈](https://github.com/starpeng/JdSdk/issues/new "问题反馈")


交流QQ群：[236361019](http://wp.qq.com/wpa/qunwpa?idkey=cf2359d5237e19515d77680427f38b46dc3d2dfa4ef596c21edbc1205413efab "236361019")
<a target="_blank" href="http://wp.qq.com/wpa/qunwpa?idkey=cf2359d5237e19515d77680427f38b46dc3d2dfa4ef596c21edbc1205413efab"><img border="0" src="http://pub.idqqimg.com/wpa/images/group.png" alt="SDK交流" title="SDK交流"></a>


## 更新记录 ##
-1.2.0
>重构代码，接口加入附加参数，以支持随时可能新增的请求参数  
>Json.Net改为使用dll引用  
>wares.search接口补充ware_status,start_modified,end_modified请求参数  
  
-1.1.6
>SkuStockUpdateResponse 更改SkuId为可空类型  
>优惠明细CouponDetail.SkuId改为String类型  


-1.1.5
> 修改一些数据类型。  
> 根据ware_id 商品编号 修改商品信息接口，去掉部分参数的必须验证   

-1.1.4
> SOP,LBP,SOPL服务接口中的流水号设置为非必须参数。  

  
-1.1.3
> 更新库存接口SkuId修改为可空类型   


- 1.1.2
> 京东快车 13个接口  
> 促销服务14个接口  
> 物流服务19个接口  
> 地址库接口共5个  
> 京东快车新增4接口  
> 图片空间6接口  
> 订购关系查询 jingdong.vas.subscribe.get  
> 获取预分配的运单号jingdong.etms.waybillcode.get  
> 提交运单信息 jingdong.etms.waybill.send  
> 获取类目信息 jingdong.union.categoryinfo.search  
> 保存计划信息 jingdong.union.plan.save  
> 获取计划基本信息 jingdong.union.planbaseinfo.get  
> 根据pin返回供应商简码和三级分类列表 jingdong.userCategory3.info.get
> 若干接口同步修改
  
  
    
  
- 1.1.1
> 360buy.order.search，360buy.order.get支持返回运单号、物流公司、增值税发票


- 1.1.0
> 将部分京东文档中为Number，明显为整形字段的由原来的Decimal替换成换成Int64。

- 1.0.9
> 增加13个直通车接口


- 1.0.8
> 修正获取上下架商品接口的错误


- 1.0.7

> ####新增接口
> 商家信息接口 jingdong.seller.vender.info.get  
海外购发货接口 360buy.overseas.order.sop.delivery  
海外购出库接口 360buy.overseas.order.sop.outstorage  
SOPL修改运单号 360buy.order.sopl.waybill.update  
LBP修改运单号 360buy.order.lbp.waybill.update  
CPS服务共18个接口 （接口名-略）  
根据SKUID获取商品价格 jingdong.ware.price.get  

>####更新接口
获取商品促销信息的接口 jingdong.ware.promotionInfo.get  
SOP修改运单号 360buy.order.sop.waybill.update  
检索商品信息接口  360buy.wares.search  
根据商品ID查询单个商品的详细信息 360buy.ware.get  
批量获取商品信息 360buy.wares.list.get  
检索商品信息接口  360buy.wares.search  
上架商品 360buy.ware.listing.get  
下架商品 360buy.ware.delisting.get  
