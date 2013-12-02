PSMReflectionBug
================

Activator.CreateInstanceがPSMだけおかしな挙動をしている件について

問題点
===========
internal classの型情報をpublic classを通じて取得し、Activator.CreateInstanceするとPSMのみMethodAccessExceptionが飛ぶ


再現環境
===========
* PlayStation Mobile Simulator
* Vita

問題の無い環境
===============
* Visual Studio 2013 + Windows
* mono 2.10.8.1 + Ubuntu


