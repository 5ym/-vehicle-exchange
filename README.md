# vehicle-exchange

## dev

先に下記環境を構築しておいてください。  
<https://github.com/5ym/Local-Dev-Traefik>  

```sh
cp compose.sample.yml compose.yml
docker compose up
sudo chown -R $USER:$USER .
```

open <http://ve.localhost>

## 予定

- フロントワイヤーフレーム(shdcn-uiのパーツでfigamで作成)
    - https://www.figma.com/file/NZzPZtSrCqqshOJLh2Ihf5/%40shadcn%2Fui---Design-System-(Community)?type=design&node-id=2%3A287&mode=design&t=m2iEpnhhghMzvZfK-1
- フロント実装
- バックエンド実装
    - 認証系とかのやり方がわからん
- open-api codegenを利用してバックエンドのapiを自動でフロントライブラリ化
- 繋ぎこみ
    - 認証系とかのやり方がわからん
