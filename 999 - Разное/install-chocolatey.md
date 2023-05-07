# Установка Chocolatey

## Краткое описание
Chocolatey - программа которая помогает устанавливать большое количество программ при помощи команд PowerShell. Этим самым минимзирует затрачиваемое время на поиск и ручную установку.

Источник: [официальный сайт](https://chocolatey.org/)

## Команда для установки

```
Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))
```