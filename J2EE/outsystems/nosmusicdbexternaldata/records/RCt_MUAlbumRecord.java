package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MUAlbumRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUAlbumRecord> {

	private static final GlobalObjectKey Idt_MUAlbum = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*o2ts_a6c9RI3CkMu9vxykg");

	public static void ensureInitialized() {}
	public ENt_MUAlbumEntityRecord ssENt_MUAlbum;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUAlbumEntityRecord toStructure() {
		return ssENt_MUAlbum;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUAlbumRecord(ENt_MUAlbumEntityRecord r) throws Exception {
		ssENt_MUAlbum = (ENt_MUAlbumEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUAlbum.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUAlbum.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUAlbumRecord() {
		OptimizedAttributes = null;
		ssENt_MUAlbum = new ENt_MUAlbumEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(7, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUAlbum.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUAlbum.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUAlbum.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MUAlbum.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MUAlbumRecord r) throws Exception {
		this.ssENt_MUAlbum = (ENt_MUAlbumEntityRecord) r.ssENt_MUAlbum.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MUAlbumRecord)) {
			return false;
		}
		RCt_MUAlbumRecord b = (RCt_MUAlbumRecord) obj;
		if (!this.ssENt_MUAlbum.equals(b.ssENt_MUAlbum)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MUAlbum.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUAlbum.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUAlbum.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUAlbumRecord duplicate() throws Exception {
		RCt_MUAlbumRecord t = new RCt_MUAlbumRecord();
		t.ssENt_MUAlbum = (ENt_MUAlbumEntityRecord) this.ssENt_MUAlbum.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MUAlbum.toXml(this, recordElem, "t_MUAlbum", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mualbum")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUAlbum")) variable.setValue(ssENt_MUAlbum); else variable.setOptimized(true);
			variable.setFieldName("t_mualbum");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUAlbumRecord t = (RCt_MUAlbumRecord) super.clone();
		t.ssENt_MUAlbum = (ENt_MUAlbumEntityRecord) this.ssENt_MUAlbum.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUAlbum.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUAlbum.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUAlbum)) {
			return ssENt_MUAlbum;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUAlbum.fillFromOther((IRecord) other.attributeGet(Idt_MUAlbum));
	}
}
