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
    private string[,] TextDeta = new string[3, 8] { { "汚れっちまった悲しみに\n今日も小雪の降りかかる\n汚れっちまった悲しみに\n今日も風さえ吹きすぎる", "汚れっちまった悲しみは\nたとえば狐の革裘（かわごろも）\n汚れっちまった悲しみは\n小雪のかかってちぢこまる","","","汚れっちまった悲しみは\nなにのぞむなくねがうなく\n汚れっちまった悲しみは\n倦怠（けだい）のうちに死を夢（ゆめ）む" ,"汚れっちまった悲しみに\nいたいたしくも怖気（おじけ）づき\n汚れっちまった悲しみに\nなすところもなく日は暮れる……","",""}, { "子供たちよ。\nこれは譲り葉の木です。\nこの譲り葉は\n新しい葉が出来ると\n入れ代つてふるい葉が落ちてしまふのです。", "こんなに厚い葉\nこんなに大きい葉でも\n新しい葉が出来ると無造作に落ちる\n新しい葉にいのちを譲つて――。","子供たちよ。\nお前たちは何を欲しがらないでも\n凡てのものがお前たちに譲られるのです。\n太陽の廻るかぎり\n譲られるものは絶えません。","輝ける大都会も\nそつくりお前たちが譲り受けるのです。\n読みきれないほどの書物も\nみんなお前たちの手に受取るのです。\n幸福なる子供たちよ\n前たちの手はまだ小さいけれど――。","世のお父さん、お母さんたちは\n何一つ持つてゆかない。\nみんなお前たちに譲ゆづつてゆくために\nいのちあるもの、よいもの、美しいものを\n一生懸命に造つてゐます。","今、お前たちは気が附かないけれど\nひとりでにいのちは延びる。\n鳥のやうにうたひ、花のやうに笑つてゐる間に気が附いてきます。","そしたら子供たちよ\nもう一度譲り葉の木の下に立つて\n譲り葉を見る時が来るでせう。",""},{ "濁みし声下より叫ぶ\n炉はいまし何度にありや\n八百といらへをすれば\n声なくて炭たんを掻く音", "声ありて更に叫べり\nづくはいまし何度にありや\n八百といらへをすれば\nまたもちえと舌打つひゞき","灼熱のるつぼをつゝみ\nむらさきの暗き火は燃え\nそがなかに水うち汲める\n母の像恍とうかべり" ,"声ありて下より叫ぶ\n針はいま何度にありや\n八百といらへて云へば\nたちまちに階を来る音","八百は何のたはごと\n汝はこゝに睡れるならん\n見よ鉄はいま千二百\nなれが眼は何を読めるや","あなあやし紫の火を\nみつめたる眼はうつろにて\n熱計の針も見わかず\n奇しき汗せなにうるほふ","あゝなれは何を泣けるぞ\n涙もて金はとくるや\n千二百いざ下り行かん\nそれいまぞ鉄は熟しぬ","融鉄はうちとゞろきて\n火花あげけむりあぐれば\n紫の焔は消えて\n室のうちにはかにくらし"} };
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
    public void koityunaka()
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
    public void gennso()
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
}