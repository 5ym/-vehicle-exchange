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

- フロントUIライブラリ選定
- フロントワイヤーフレーム
- フロント実装
- バックエンド実装
- open-api codegenを利用してバックエンドのapiを自動でフロントライブラリ化