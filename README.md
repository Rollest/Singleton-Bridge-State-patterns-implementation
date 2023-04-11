# Singleton-Bridge-State-patterns-implementation!
В данной программе используются следующие паттерны проектирования:

Singleton - это порождающий паттерн, который гарантирует существование только одного экземпляра класса и предоставляет глобальную точку доступа к этому экземпляру. В данной программе класс DeviceSingleton реализует этот паттерн, гарантируя, что для каждого типа устройства существует только один экземпляр объекта.

Bridge - это структурный паттерн, который разделяет абстракцию и реализацию, позволяя им изменяться независимо друг от друга. В данной программе классы Device и IDeviceImplementation представляют абстракцию и реализацию соответственно, а классы LightImplementation и другие подобные классы представляют конкретные реализации.

State - это поведенческий паттерн, который позволяет объекту изменять своё поведение в зависимости от своего внутреннего состояния. В данной программе классы DeviceState, OffState и OnState представляют различные состояния объекта Device, а методы On и Off в этих классах реализуют различное поведение объекта в зависимости от его состояния.
<h1 align="center">UML программы <a href="https://daniilshat.ru/" target="_blank">Daniil</a> 
<img src="https://github.com/blackcater/blackcater/raw/main/images/Hi.gif" height="32"/></h1>
![jLJ1YeCm4BtdAt9Kklw0BAM7mY8iU73l4kBO1dHQJBfGblvxex4nYMdtikify-RDcvbdo4ugDgXBtn72EoObtSEtu509F7IWJaX_2DLVHZLF2KvhWVg476HEzu8hSK8sND-b6dJ5MrYzdOi3E4adVFCG_G1LpB99Cr6_hcV8gL5Dyx2Ut0WHg61e6GTQc6pHdple0KT9E_U6baktictr-U](https://user-images.githubusercontent.com/104532816/231233672-07be15e6-2d62-428c-8991-990e1b91364e.png)
