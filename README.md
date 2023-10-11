# NotAGame

- Platform Game  
플랫폼을 밟으며 위로 올라가는 게임을 구현했습니다.  
심화 강의에서 쓰인 플레이어 디자인이 'ALTF4' 게임과 닮아 플랫폼 게임 장르가 생각났습니다.  

- SavePoint  
땅을 밟거나 체력이 다 닳게 되면 플레이어가 죽고 다시 SavePoint에서 시작하는 것을 구현하고자 했으나  
기존에 강의를 들으며 구현한 플레이어의 Rigidbody 등으로 인해, 플레이어와 땅이 충돌하면 플레이어 오브젝트의 모션, 컨트롤에 영향을 주어 해당 구현은 포기했습니다.  
대신 몇몇 SavePoint를 도달할 시 Second, ThirdScene으로 전환하도록 설정하여 SavePoint 기능을 씬 전환 방식으로나마 구현했습니다.  

- Sound  
배경음악 A 진행 중 플레이어가 일정 시간 이상 추락하게 되면 다른 배경음악 B가 재생되고, B 재생이 끝나면 다시 A가 재생되도록 설정했습니다.  

- 기타  
강의에서 배운 VirtualCamera, PlayerSO 등의 설정값을 크게 바꾸어 보며 카메라의 시야, Damping, 플레이어 속도에 따라 카메라가 어떤 영향을 받는지,  
ProBuilder에는 또 어떤 기능들이 있는지 등 하나하나 만져보며 연구했습니다.  
맵을 만드는 부분이 처음 생각한 것보다 심하게 노가다라.. 맵 관련해서는 적당히만 진행했습니다.  


---
- 그 외 기록들  
  
  - 초기 기획  
https://dh4934.tistory.com/70  

  - SavePoint 구현 시 애로사항 / Scene loading 시 오류  
https://dh4934.tistory.com/71  

  - 배경음악  
https://dh4934.tistory.com/72  
