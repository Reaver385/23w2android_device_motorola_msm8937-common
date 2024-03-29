#
# Copyright (C) 2017 The LineageOS Project
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
# http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.


[AID_QCOM_DIAG]
value:2901

[AID_RFS]
value:2903

[AID_RFS_SHARED]
value:2904

[system/vendor/bin/wcnss_filter]
mode: 0755
user: AID_BLUETOOTH
group: AID_BLUETOOTH
caps: BLOCK_SUSPEND

[system/vendor/bin/cnss-daemon]
mode: 0755
user: AID_BLUETOOTH
group: AID_BLUETOOTH
caps: NET_BIND_SERVICE

[system/vendor/bin/imsdatadaemon]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[system/vendor/bin/ims_rtp_daemon]
user: AID_SYSTEM
group: AID_RADIO
mode: 0755
caps: NET_BIND_SERVICE

[system/vendor/bin/pm-service]
user: AID_SYSTEM
group: AID_SYSTEM
mode: 0755
caps: NET_BIND_SERVICE

[system/vendor/bin/cnd]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE BLOCK_SUSPEND NET_ADMIN

[system/vendor/bin/slim_daemon]
mode: 0755
user:  AID_GPS
group: AID_GPS
caps: NET_BIND_SERVICE

[system/vendor/bin/xtwifi-client]
mode: 0755
user:  AID_GPS
group: AID_GPS
caps: NET_BIND_SERVICE BLOCK_SUSPEND

[system/vendor/bin/mm-qcamera-daemon]
mode: 0700
user: AID_CAMERA
group: AID_SHELL
caps: SYS_NICE

[firmware/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[persist/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[AID_MOT_ACCY]
value: 9000

[AID_MOT_PWRIC]
value: 9001

[AID_MOT_USB]
value: 9002

[AID_MOT_DRM]
value: 9003

[AID_MOT_TCMD]
value: 9004

[AID_MOT_SEC_RTC]
value: 9005

[AID_MOT_TOMBSTONE]
value: 9006

[AID_MOT_TPAPI]
value: 9007

[AID_MOT_SECCLKD]
value: 9008

[AID_MOT_WHISPER]
value: 9009

[AID_MOT_CAIF]
value: 9010

[AID_MOT_DLNA]
value: 9011

[AID_MOT_ATVC]
value: 9012

[AID_MOT_DBVC]
value: 9014

[AID_FINGERP]
value: 9015

[AID_MOT_ESDFS]
value: 9016

[AID_MOT_ESDFS]
value: 9016

[AID_MOT_ESDFS]
value: 9016

[AID_POWER]
value: 9017

[AID_ITSON]
value: 9018

[AID_MOT_DTV]
value: 9019

[AID_MOT_MOD]
value: 9020

[AID_MOT_SHARED]
value: 9323

[AID_MOT_COMMON]
value: 9341

