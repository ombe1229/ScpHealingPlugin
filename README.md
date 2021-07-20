# ScpHealingPlugin

SCP:SL SCP 체력 회복 플러그인

Config 파일 세부화, 기능 추가 등은 디스코드 **ombe#3619**에게 유료로 구매 가능

## 기능

- SCP가 인간을 처치할 시 체력 회복

## Config

|      설정      | 변수 타입  |                                                            기본값                                                             | 설명                       |
| :------------: | :--------: | :---------------------------------------------------------------------------------------------------------------------------: | :------------------------- |
|   is_enabled   |  Boolean   |                                                             true                                                              | 플러그인을 키거나 끕니다.  |
| HealingAmount  | Dictionary |                                                             생략                                                              | 처치 시 회복할 체력        |
| HealingMessage |   String   | "인간을 처치하여 <color=red>HP</color>가 <color=red>{N}</color>만큼 회복되었습니다.\n현재 <color=red>HP</color>: {NOW}/{MAX}" | 회복 후 상단에 띄울 메세지 |

### 라이센스

ScpHealingPlugin은 BSD-3-Clause 라이센스를 따르고 있습니다.
