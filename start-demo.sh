#!/usr/bin/env bash

rscp ./bin/Debug/netcoreapp2.0/ /opt/lca-api/
echo 'Copy service file to /etc/systemd/system/'
sudo cp ./lca-api.service /etc/systemd/system/
echo 'Reload systemd with systemctl daemon-reload'
sudo systemctl daemon-reload
echo 'Check status'
systemctl status lca-api.service
