using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class TestSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProGeometryAnimation animationDatas;
    private GameObject[] MoveText;
    private string[,] TextDeta = new string[5, 8] { {"汚れっちまった悲しみに:中原中也\n汚れっちまった悲しみに\n今日も小雪の降りかかる\n汚れっちまった悲しみに\n今日も風さえ吹きすぎる", "汚れっちまった悲しみは\nたとえば狐の革裘（かわごろも）\n汚れっちまった悲しみは\n小雪のかかってちぢこまる", "汚れっちまった悲しみは\nなにのぞむなくねがうなく\n汚れっちまった悲しみは\n倦怠（けだい）のうちに死を夢（ゆめ）む", "汚れっちまった悲しみに\nいたいたしくも怖気（おじけ）づき\n汚れっちまった悲しみに\nなすところもなく日は暮れる……", "　", "　"," "," " }, {  "　　もしも、あめのかはりに\n村山籌子\nもしも、あめのかはりに\n　　ねこだの\n　　いぬだの\n　　ねずみだのがふつてきたら\n　　まあ、\n　　どんなにおかしいでせうね。", "　　　そして、\n　　　それが、\n　　　いくにちも\n　　　いくにちも\n　　　ふりつづけたら、","　　　まあ\n　　　せかいぢうは\n　　　ねこだらけ、\n　　　いぬだらけ、\n　　　ねずみだらけに\n　　　なるでせうね。"," "," "," "," "," "}, { "蟻地獄\n萩原朔太郎","ありぢごくは蟻をとらへんとて\nおとし穴の底にひそみかくれぬ\nありぢごくの貪婪(たんらん)の瞳に\nかげろふはちらりちらりと燃えてあさましや。" ,"ほろほろと砂のくづれ落つるひびきに\nありぢごくはおどろきて隱れ家をはしりいづれば\nなにかしらねどうす紅く長きものが走りて居たりき。","ありぢごくの黒い手脚に\nかんかんと日の照りつける夏の日のまつぴるま\nあるかなきかの蟲けらの落す涙は\n草の葉のうへに光りて消えゆけり。\nあとかたもなく消えゆけり。"," "," "," "," "},{ "山の歓喜:河井酔茗\nあらゆる山が歓んでゐる\nあらゆる山が語つてゐる\nあらゆる山が足ぶみして舞ふ、躍る", "　　　あちらむく山と\n　　　こちらむく山と\n　　　合つたり\n　　　離れたり" ,"　　　出てくる山と\n　　　かくれる山と\n　　　低くなり\n　　　高くなり","　　　家族のやうに親しい山と\n　　　他人のやうに疎い山と\n　　　遠くなり\n　　　近くなり","　　　あらゆる山が\n　　　山の日に歓喜し\n　　　山の愛にうなづき","　　　今や\n　　　生のかがやきは\n　　　空いつぱいにひろがつてゐる"," "," "},{ "明日\n新美南吉" ,"花園みたいにまつてゐる。\n祭みたいにまつてゐる。\n明日がみんなをまつてゐる。","草の芽\nあめ牛、てんと虫。\n明日はみんなをまつてゐる。","明日はさなぎが蝶(てふ)になる。\n明日はつぼみが花になる。\n明日は卵がひなになる。","明日はみんなをまつてゐる。\n泉のやうにわいてゐる。\nらんぷのやうに点(とも)つてる。"," "," "," "} };
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public GameObject page6;
    public GameObject page7;
    public GameObject page8;
    private TMPro.TMP_Text newText;


    public void taperaita() 
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {

            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled =false;
            MoveText[i].GetComponent<OneCharacterOn>().enabled =true;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }
    }
    public void positionNoise()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = true;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
            MoveText[i].GetComponent<OneCharacterOn>().Finish();
        }
    }
    public void scale()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = true;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
            MoveText[i].GetComponent<OneCharacterOn>().Finish();
        }
    }
    public void scaleNoise()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = true;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
            MoveText[i].GetComponent<OneCharacterOn>().Finish();
        }
    }
    public void rotation()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = true;
            animationDatas.scaleNoise.use = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
            MoveText[i].GetComponent<OneCharacterOn>().Finish();
        }
    }
    public void plean()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
            MoveText[i].GetComponent<OneCharacterOn>().Finish();
        }
    }

    public void yogorecchimattakanashimini()
    {
        newText = page1.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 0];
        newText = page2.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 1];
        newText = page3.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 2];
        newText = page4.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 3];
        newText = page5.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 4];
        newText = page6.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 5];
        newText = page7.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 6];
        newText = page8.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[0, 7];
    }
    public void moshimoamenokawarini()
    {
        newText = page1.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 0];
        newText = page2.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 1];
        newText = page3.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 2];
        newText = page4.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 3];
        newText = page5.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 4];
        newText = page6.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 5];
        newText = page7.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 6];
        newText = page8.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[1, 7];
    }
    public void arizigoku()
    {
        newText = page1.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 0];
        newText = page2.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 1];
        newText = page3.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 2];
        newText = page4.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 3];
        newText = page5.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 4];
        newText = page6.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 5];
        newText = page7.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 6];
        newText = page8.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[2, 7];
    }
    public void yamanokannki()
    {
        newText = page1.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 0];
        newText = page2.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 1];
        newText = page3.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 2];
        newText = page4.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 3];
        newText = page5.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 4];
        newText = page6.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 5];
        newText = page7.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 6];
        newText = page8.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[3, 7];
    }
    public void ashita()
    {
        newText = page1.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 0];
        newText = page2.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 1];
        newText = page3.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 2];
        newText = page4.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 3];
        newText = page5.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 4];
        newText = page6.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 5];
        newText = page7.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 6];
        newText = page8.GetComponent<TMPro.TMP_Text>();
        newText.text = TextDeta[4, 7];
    }
}