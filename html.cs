<button class="cool-btn">
    <!-- ใส่ชื่อไฟล์รูปภาพของคุณตรงนี้ -->
    <img src="dhalf 2026-06-06 1239254B55C81548D9.jpg" alt="My Photo" class="btn-image">
    ชี้ที่ฉันสิ! 💕
</button>

<style>
.cool-btn {
  background-color: #ffb6c1; /* สีชมพูพาสเทลหลัก */
  color: #6b4f4f;            /* สีตัวอักษรน้ำตาลหม่นสไตล์มินิมอล */
  padding: 10px 25px 10px 15px; /* เว้นระยะด้านซ้ายขวาให้สมดุล */
  font-size: 18px;
  font-weight: bold;
  border: none;
  border-radius: 30px;       /* ทำมุมโค้งมนแบบปุ่มตะมุตะมิ */
  cursor: pointer;
  
  display: inline-flex;
  align-items: center;
  justify-content: center;
  gap: 12px;                 /* ระยะห่างระหว่างรูปภาพกับข้อความ */
  
  /* เพิ่มเงาสีชมพูจางๆ ให้ปุ่มดูนุ่มนวล */
  box-shadow: 0px 4px 10px rgba(255, 182, 193, 0.4); 
  transition: all 0.3s ease; /* เล่นแอนิเมชันนุ่มนวลเวลาขยับ */
}

.btn-image {
  width: 45px;               /* ขนาดความกว้างของรูป */
  height: 45px;              /* ขนาดความสูงของรูป */
  border-radius: 50%;        /* ตัดรูปให้เป็นวงกลมมนๆ */
  object-fit: cover;         /* จัดการรูปให้พอดีกรอบวงกลม ไม่เบี้ยวไม่ยืด */
  border: 2px solid white;   /* เพิ่มขอบเส้นสีขาวให้รูปภาพดูเด่นขึ้น */
}

/* เอฟเฟกต์ตอนเอาเมาส์มาวาง (Hover) */
.cool-btn:hover {
  background-color: #ffd1b3; /* เปลี่ยนเป็นสีพีชพาสเทล */
  transform: scale(1.08);    /* ขยายใหญ่ขึ้นเล็กน้อย */
  box-shadow: 0px 8px 20px rgba(255, 182, 193, 0.6); /* เงาฟูขึ้นดูมีมิติ */
}
</style>
