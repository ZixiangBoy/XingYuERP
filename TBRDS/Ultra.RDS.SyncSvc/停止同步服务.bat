@echo off
@if "%1"=="y" goto op
set/p n=ȷ��Ҫֹͣ���з�����? ���� y ֹͣ���з���,���� n �˳�.
if /i %n% neq y exit/b

:op
sc stop UltraRDS
