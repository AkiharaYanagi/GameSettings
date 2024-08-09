﻿# include <Siv3D.hpp> // Siv3D v0.6.13
#include "03_GameInput.h"
#include "Ctrl_KeyConfig.h"


using namespace GAME;


void Init ();


void Main()
{
	//タイトルバー
	s3d::Window::SetTitle ( U"キーコンフィグ" );

	//キーコンフィグ　コントロール
	Ctrl_KeyConfig		ctrl_KeyConfig;
	ctrl_KeyConfig.Load ();

	//入力の監理
	SivInput::Create ();


	//========================================
	//メインループ
	bool init = F;
	while ( System::Update() )
	{
		//1回のみ初期化
		if ( ! init ) { Init (); init = T; }

		//毎回の更新
		const Array<Input> & keys = s3d::Keyboard::GetAllInputs();
		SivInput::Inst()->Update ( keys );

		//動作
		ctrl_KeyConfig.Move ();

		//描画
		ctrl_KeyConfig.Draw ();
	}
	//========================================
}

void Init ()
{
	//カーソル位置にウィンドウを移動
	WND_UTL::MoveWindow_toCursor ();
}
