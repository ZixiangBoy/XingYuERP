@echo off
set/p n=ȷ��Ҫж�����з�����? ���� y ����ж��,���� n �˳�.
if /i %n% neq y exit/b

sc stop UltraRDS
%systemroot%\Microsoft.NET\Framework\v4.0.30319\InstallUtil.exe /u Ultra.RDS.SyncSvc.exe