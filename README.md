<h1 data-start="101" data-end="130" class="">Katmanlı Mimari Projesi 🏗️</h1>
<p data-start="132" data-end="574" class=""><strong data-start="132" data-end="151">Katmanlı Mimari</strong> projesi, yazılım geliştirmede çok katmanlı mimari desenini (layered architecture) göstermeyi amaçlayan bir projedir. Bu proje, <strong data-start="279" data-end="308">Veri Erişim Katmanı (DAL)</strong>, <strong data-start="310" data-end="343">Varlık Katmanı (Entity Layer)</strong>, <strong data-start="345" data-end="376">İşlem Katmanı (Logic Layer)</strong> ve <strong data-start="380" data-end="418">Sunum Katmanı (Presentation Layer)</strong> olmak üzere dört farklı katmandan oluşmaktadır. Her bir katman,
  kendi sorumluluğuna sahiptir ve diğer katmanlarla düzenli ve modüler bir şekilde etkileşir.</p>
  <h2 data-start="576" data-end="591" class="">Özellikler ✨</h2>
<ul data-start="592" data-end="1066">
<li data-start="592" data-end="714" class="" style="">
<p data-start="594" data-end="714" class=""><strong data-start="594" data-end="623">Veri Erişim Katmanı (DAL)</strong>: Tüm veritabanı işlemleri ve verilerin veritabanından alınması işlemlerini gerçekleştirir.</p>
</li>
<li data-start="715" data-end="823" class="" style="">
<p data-start="717" data-end="823" class=""><strong data-start="717" data-end="750">Varlık Katmanı (Entity Layer)</strong>: Veri nesnelerini ve iş mantığını temsil eden varlık sınıflarını içerir.</p>
</li>
<li data-start="824" data-end="947" class="" style="">
<p data-start="826" data-end="947" class=""><strong data-start="826" data-end="857">İşlem Katmanı (Logic Layer)</strong>: İşlem mantığını kapsar ve Varlık Katmanı ile Veri Erişim Katmanı arasında aracılık eder.</p>
</li>
<li data-start="948" data-end="1066" class="" style="">
<p data-start="950" data-end="1066" class=""><strong data-start="950" data-end="988">Sunum Katmanı (Presentation Layer)</strong>: Kullanıcı ile etkileşime girilen grafiksel kullanıcı arayüzünü (GUI) sağlar.</p>
</li>
</ul>
  
  <h2 data-start="1068" data-end="1087" class="">Teknolojiler 🛠️</h2>
  <ul data-start="1088" data-end="1211">
<li data-start="1088" data-end="1114" class="" style="">
<p data-start="1090" data-end="1114" class=""><strong data-start="1090" data-end="1110">Programlama Dili</strong>: C#</p>
</li>
<li data-start="1115" data-end="1154" class="" style="">
<p data-start="1117" data-end="1154" class=""><strong data-start="1117" data-end="1138">Çerçeve/Framework</strong>: .NET Framework</p>
</li>
<li data-start="1155" data-end="1211" class="" style="">
<p data-start="1157" data-end="1211" class=""><strong data-start="1157" data-end="1182">Veritabanı Bağlantısı</strong>: Entity Framework (DAL için)</p>
</li>
</ul>

<h2 data-start="1213" data-end="1231" class="">Proje Yapısı 📂</h2>
<pre class="overflow-visible!" data-start="1232" data-end="1819"><div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary"><div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">mathematica</div><div class="sticky top-9"><div class="absolute end-0 bottom-0 flex h-9 items-center pe-2"><div class="bg-token-sidebar-surface-primary text-token-text-secondary dark:bg-token-main-surface-secondary flex items-center rounded-sm px-2 font-sans text-xs"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Kopyala"><svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="icon-xs"><path fill-rule="evenodd" clip-rule="evenodd" d="M7 5C7 3.34315 8.34315 2 10 2H19C20.6569 2 22 3.34315 22 5V14C22 15.6569 20.6569 17 19 17H17V19C17 20.6569 15.6569 22 14 22H5C3.34315 22 2 20.6569 2 19V10C2 8.34315 3.34315 7 5 7H7V5ZM9 7H14C15.6569 7 17 8.34315 17 10V15H19C19.5523 15 20 14.5523 20 14V5C20 4.44772 19.5523 4 19 4H10C9.44772 4 9 4.44772 9 5V7ZM5 9C4.44772 9 4 9.44772 4 10V19C4 19.5523 4.44772 20 5 20H14C14.5523 20 15 19.5523 15 19V10C15 9.44772 14.5523 9 14 9H5Z" fill="currentColor"></path></svg>Kopyala</button></span><span class="" data-state="closed"><button class="flex items-center gap-1 px-4 py-1 select-none"><svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="icon-xs"><path d="M2.5 5.5C4.3 5.2 5.2 4 5.5 2.5C5.8 4 6.7 5.2 8.5 5.5C6.7 5.8 5.8 7 5.5 8.5C5.2 7 4.3 5.8 2.5 5.5Z" fill="currentColor" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round"></path><path d="M5.66282 16.5231L5.18413 19.3952C5.12203 19.7678 5.09098 19.9541 5.14876 20.0888C5.19933 20.2067 5.29328 20.3007 5.41118 20.3512C5.54589 20.409 5.73218 20.378 6.10476 20.3159L8.97693 19.8372C9.72813 19.712 10.1037 19.6494 10.4542 19.521C10.7652 19.407 11.0608 19.2549 11.3343 19.068C11.6425 18.8575 11.9118 18.5882 12.4503 18.0497L20 10.5C21.3807 9.11929 21.3807 6.88071 20 5.5C18.6193 4.11929 16.3807 4.11929 15 5.5L7.45026 13.0497C6.91175 13.5882 6.6425 13.8575 6.43197 14.1657C6.24513 14.4392 6.09299 14.7348 5.97903 15.0458C5.85062 15.3963 5.78802 15.7719 5.66282 16.5231Z" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path><path d="M14.5 7L18.5 11" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path></svg>Düzenle</button></span></div></div></div><div class="overflow-y-auto p-4" dir="ltr"><code class="whitespace-pre!"><span><span><span class="hljs-variable">LayeredArchitecture</span></span><span><span class="hljs-operator">/</span></span><span>
├── </span><span><span class="hljs-variable">DataAccessLayer</span></span><span><span class="hljs-operator">/</span></span><span>
│   ├── </span><span><span class="hljs-variable">Connection</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   ├── </span><span><span class="hljs-variable">DALPersonel</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   ├── </span><span><span class="hljs-variable">DataAccessLayer</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">csproj</span></span><span>
│   ├── </span><span><span class="hljs-variable">bin</span></span><span><span class="hljs-operator">/</span></span><span>
│   ├── </span><span><span class="hljs-variable">obj</span></span><span><span class="hljs-operator">/</span></span><span>
│   └── </span><span><span class="hljs-built_in">Properties</span></span><span><span class="hljs-operator">/</span></span><span>
├── </span><span><span class="hljs-variable">EntityLayer</span></span><span><span class="hljs-operator">/</span></span><span>
│   ├── </span><span><span class="hljs-variable">EntityDepartment</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   ├── </span><span><span class="hljs-variable">EntityPersonel</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   ├── </span><span><span class="hljs-variable">EntityLayer</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">csproj</span></span><span>
│   ├── </span><span><span class="hljs-variable">bin</span></span><span><span class="hljs-operator">/</span></span><span>
│   ├── </span><span><span class="hljs-variable">obj</span></span><span><span class="hljs-operator">/</span></span><span>
│   └── </span><span><span class="hljs-built_in">Properties</span></span><span><span class="hljs-operator">/</span></span><span>
├── </span><span><span class="hljs-variable">LayeredArchitecture</span></span><span><span class="hljs-operator">/</span></span><span>
│   ├── </span><span><span class="hljs-variable">App</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">config</span></span><span>
│   ├── </span><span><span class="hljs-variable">Architecture</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   ├── </span><span><span class="hljs-variable">Form1</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   ├── </span><span><span class="hljs-variable">LayeredArchitecture</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">csproj</span></span><span>
│   ├── </span><span><span class="hljs-variable">Program</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
│   └── </span><span><span class="hljs-built_in">Properties</span></span><span><span class="hljs-operator">/</span></span><span>
└── </span><span><span class="hljs-variable">LogicLayer</span></span><span><span class="hljs-operator">/</span></span><span>
    ├── </span><span><span class="hljs-variable">LogicLayer</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">csproj</span></span><span>
    ├── </span><span><span class="hljs-variable">LogicPersonel</span></span><span><span class="hljs-operator">.</span></span><span><span class="hljs-variable">cs</span></span><span>
    ├── </span><span><span class="hljs-variable">bin</span></span><span><span class="hljs-operator">/</span></span><span>
    ├── </span><span><span class="hljs-variable">obj</span></span><span><span class="hljs-operator">/</span></span><span>
    └── </span><span><span class="hljs-built_in">Properties</span></span><span><span class="hljs-operator">/</span></span><span>
</span></span></code></div></div></pre>

<h3 data-start="1821" data-end="1850" class="">Veri Erişim Katmanı (DAL)</h3>
<p data-start="1851" data-end="1998" class="">Bu katman, veritabanı ile etkileşimi, verilerin alınmasını ve depolanmasını yönetir. 
  <strong data-start="1936" data-end="1956">Entity Framework</strong> kullanarak veritabanı ile iletişim kurar.</p>
  <h3 data-start="2000" data-end="2033" class="">Varlık Katmanı (Entity Layer)</h3>
  <p data-start="2034" data-end="2144" class="">Veri yapılarının tanımlandığı ve veri nesnelerini tutan basit POCO (Plain Old CLR Objects) sınıflarını içerir.</p>
<h3 data-start="2146" data-end="2177" class="">İşlem Katmanı (Logic Layer)</h3>
<p data-start="2178" data-end="2277" class="">Veri işleme mantığını içerir ve <strong data-start="2210" data-end="2226">Entity Layer</strong> ile 
  <strong data-start="2231" data-end="2252">Data Access Layer</strong> arasında aracılık yapar.</p>
  <h3 data-start="2279" data-end="2317" class="">Sunum Katmanı (Presentation Layer)</h3>
  <p data-start="2318" data-end="2417" class="">Kullanıcıların uygulama ile etkileşime girebilmesi için grafiksel kullanıcı arayüzünü (GUI) sağlar.</p>
  
<h2 data-start="2419" data-end="2432" class="">Kurulum 🔧</h2>
<ol data-start="2434" data-end="2459">
<li data-start="2434" data-end="2459" class="" style="">
<p data-start="2437" data-end="2459" class=""><strong data-start="2437" data-end="2458">Repo'yu Klonlayın</strong>:</p>
</li>
</ol>
<pre class="overflow-visible!" data-start="2461" data-end="2563"><div class="contain-inline-size rounded-md border-[0.5px] border-token-border-medium relative bg-token-sidebar-surface-primary"><div class="flex items-center text-token-text-secondary px-4 py-2 text-xs font-sans justify-between h-9 bg-token-sidebar-surface-primary dark:bg-token-main-surface-secondary select-none rounded-t-[5px]">bash</div><div class="sticky top-9"><div class="absolute end-0 bottom-0 flex h-9 items-center pe-2"><div class="bg-token-sidebar-surface-primary text-token-text-secondary dark:bg-token-main-surface-secondary flex items-center rounded-sm px-2 font-sans text-xs"><span class="" data-state="closed"><button class="flex gap-1 items-center select-none px-4 py-1" aria-label="Kopyala"><svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="icon-xs"><path fill-rule="evenodd" clip-rule="evenodd" d="M7 5C7 3.34315 8.34315 2 10 2H19C20.6569 2 22 3.34315 22 5V14C22 15.6569 20.6569 17 19 17H17V19C17 20.6569 15.6569 22 14 22H5C3.34315 22 2 20.6569 2 19V10C2 8.34315 3.34315 7 5 7H7V5ZM9 7H14C15.6569 7 17 8.34315 17 10V15H19C19.5523 15 20 14.5523 20 14V5C20 4.44772 19.5523 4 19 4H10C9.44772 4 9 4.44772 9 5V7ZM5 9C4.44772 9 4 9.44772 4 10V19C4 19.5523 4.44772 20 5 20H14C14.5523 20 15 19.5523 15 19V10C15 9.44772 14.5523 9 14 9H5Z" fill="currentColor"></path></svg>Kopyala</button></span><span class="" data-state="closed"><button class="flex items-center gap-1 px-4 py-1 select-none"><svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg" class="icon-xs"><path d="M2.5 5.5C4.3 5.2 5.2 4 5.5 2.5C5.8 4 6.7 5.2 8.5 5.5C6.7 5.8 5.8 7 5.5 8.5C5.2 7 4.3 5.8 2.5 5.5Z" fill="currentColor" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round"></path><path d="M5.66282 16.5231L5.18413 19.3952C5.12203 19.7678 5.09098 19.9541 5.14876 20.0888C5.19933 20.2067 5.29328 20.3007 5.41118 20.3512C5.54589 20.409 5.73218 20.378 6.10476 20.3159L8.97693 19.8372C9.72813 19.712 10.1037 19.6494 10.4542 19.521C10.7652 19.407 11.0608 19.2549 11.3343 19.068C11.6425 18.8575 11.9118 18.5882 12.4503 18.0497L20 10.5C21.3807 9.11929 21.3807 6.88071 20 5.5C18.6193 4.11929 16.3807 4.11929 15 5.5L7.45026 13.0497C6.91175 13.5882 6.6425 13.8575 6.43197 14.1657C6.24513 14.4392 6.09299 14.7348 5.97903 15.0458C5.85062 15.3963 5.78802 15.7719 5.66282 16.5231Z" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path><path d="M14.5 7L18.5 11" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path></svg>Düzenle</button></span></div></div></div><div class="overflow-y-auto p-4" dir="ltr"><code class="whitespace-pre! language-bash"><span><span>git </span><span><span class="hljs-built_in">clone</span></span><span> https://github.com/mervesevim44/layered_architecture.git
</span><span><span class="hljs-built_in">cd</span></span><span> layered_architecture
</span></span></code></div></div></pre>

<ol start="2" data-start="2565" data-end="2728">
<li data-start="2565" data-end="2728" class="">
<p data-start="2568" data-end="2591" class=""><strong data-start="2568" data-end="2590">Projeyi Çalıştırın</strong>:</p>
<ul data-start="2595" data-end="2728">
<li data-start="2595" data-end="2656" class="">
<p data-start="2597" data-end="2656" class=""><code data-start="2597" data-end="2622">LayeredArchitecture.sln</code> dosyasını Visual Studio ile açın.</p>
</li>
<li data-start="2660" data-end="2702" class="">
<p data-start="2662" data-end="2702" class=""><code data-start="2662" data-end="2680">Ctrl + Shift + B</code> ile projeyi derleyin.</p>
</li>
<li data-start="2706" data-end="2728" class="">
<p data-start="2708" data-end="2728" class=""><code data-start="2708" data-end="2712">F5</code> ile çalıştırın.</p>
</li>
</ul>
</li>
</ol>






